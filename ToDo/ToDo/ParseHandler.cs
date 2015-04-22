using System;
using System.Linq;
using Parse;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToDo
{
	public class ParseHandler
	{

		static ParseHandler todoServiceInstance = new ParseHandler();
		public static ParseHandler Default { get { return todoServiceInstance;} }
		private ParseHandler () {
		}
		public async Task CreateUserAsync (string username, string email, string password)
		{
			if (username != "" && email != "" && password != "") {
				var user = new ParseUser () {
					Username = username,
					Password = password,
					Email = email

				};
				await user.SignUpAsync ();
			}
		}
		public async Task <Boolean> CheckIfUserNameExists (string username)
		{
			var query = ParseUser.Query;
			var queryresult = await query.WhereEqualTo ("username", username).FindAsync ();
			if (queryresult.ToList ().Count > 0) {
				return true;

			} else {
				return false;
			}

		}
		public  async Task<Boolean> Login (string username, string password)
		{
			try 
			{
				await ParseUser.LogInAsync(username, password);
				return true;
			}
			catch (Exception e) {
				Console.WriteLine ("Login Failed :" + e.Message);
				return false;
			}
		}

		public async Task<Boolean> AddToDoItem(string ItemDescription)
		{
			ParseObject ToDo = new ParseObject ("tblToDo");
			ToDo ["ItemDescription"] = ItemDescription;
			ToDo ["User"] = ParseUser.CurrentUser;

			try {
				await ToDo.SaveAsync ();
				return true;
			} catch (Exception e) {
				Console.WriteLine ("Error:" + e.Message);
				return false;
			}
		}

		public async Task<List<ToDo>> GetAll ()
		{
			var query = ParseObject.GetQuery ("tblToDo").WhereEqualTo ("User", ParseUser.CurrentUser);
			var result = await query.FindAsync ();

			var ToDoList = new List<ToDo> ();

			foreach (var obj in result) {

				ToDo tempobj = new ToDo ();

				tempobj.ObjectId = obj.ObjectId;
				tempobj.createdAt = obj.CreatedAt;
				tempobj.updatedAt = obj.UpdatedAt;
				tempobj.ItemDescription = Convert.ToString (obj ["ItemDescription"]);

				ToDoList.Add (tempobj);
			}
			return ToDoList;
		}

		public async void DeleteItem(ToDo ToDoItem)
		{
			ParseObject ToDo = new ParseObject ("tblToDo");

			ToDo.ObjectId = ToDoItem.ObjectId;
			ToDo ["ItemDescription"] = ToDoItem.ItemDescription;
			ToDo ["User"] = ParseUser.CurrentUser;

			try {
				await ToDo.DeleteAsync ();
			} catch (Exception e) {
				Console.Error.WriteLine (@"ERROR {0}", e.Message);
			}
		}



	}
}

