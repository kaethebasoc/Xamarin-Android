
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ToDo
{
	[Activity (Label = "ViewList")]			
	public class ViewList : Activity
	{

		EditText txtToDo;
		Button btnAdd;
		ListView lstItems;
		List<ToDo> ToDoList = new List<ToDo> ();

		ParseHandler objParse = ParseHandler.Default;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.ListActivity);

			btnAdd = FindViewById<Button> (Resource.Id.btnAdd);
			txtToDo = FindViewById<EditText> (Resource.Id.txtToDo);
			lstItems = FindViewById<ListView> (Resource.Id.lstItems);

			btnAdd.Click += AddToDoItem;
			lstItems.ItemLongClick += OnListViewLongClick;

			LoadToDoItems ();

		}

		public async void AddToDoItem (object sender, EventArgs e)
		{
			if (txtToDo.Text != "") {
				var result = await objParse.AddToDoItem (txtToDo.Text);

				if (result == true) {
					Toast.MakeText (this, "Item added successfully", ToastLength.Long).Show ();
					LoadToDoItems ();
					txtToDo.Text = "";


				} else {
					Toast.MakeText (this, "Oops something went wrong", ToastLength.Long).Show();
				}
			}
		}

		public async void LoadToDoItems()
		{
			ToDoList = await objParse.GetAll ();
			lstItems.Adapter = new DataAdapter (this, ToDoList);
		}

		public void OnListViewLongClick (object sender, AdapterView.ItemLongClickEventArgs e)
		{
			var ToDoItem = ToDoList [e.Position];
			var builder = new AlertDialog.Builder (this);

			builder.SetMessage ("Do yo wish to delete the item:" + ToDoItem.ItemDescription);
			builder.SetPositiveButton ("Yes", (s, ea) => {
				objParse.DeleteItem(ToDoItem);
				Toast.MakeText (this, "Item Deleted", ToastLength.Long).Show ();
				LoadToDoItems ();
				builder.Dispose ();
			});

			builder.SetNegativeButton ("No", (s, ea) => {
				builder.Dispose ();
			});

			builder.Create ().Show ();
		}

	}
}

