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

namespace QuickNote
{
	[Activity (Label = "Main")]			
	public class Main : Activity
	{

		//Button btnAdd;
		//Button btnDelete;

		DatabaseManager objDb;


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here



			SetContentView (Resource.Layout.AddItem);

			//btnAdd = FindViewById<Button> (Resource.Id.btnAdd);
			//btnDelete = FindViewById<Button> (Resource.Id.btnDelete);



			//btnAdd.Click += OnBtnAddClick;
			//btnDelete.Click += OnBtnDeleteClick;




			objDb = new DatabaseManager();

			//btnAdd.Click += OnBtnAddClick;
		}

		private void OnBtnAddClick(object sender,EventArgs e)
		{
			// if (txtItemTitle.Text != "" && txtItemDescription.Text != "")
			//{
				// objdb.AddItem (txtItemTitle.Text, txtItemDescription.Text);
				Toast.MakeText (this, "Note Added", ToastLength.Long).Show();
				this.Finish ();
				StartActivity (typeof(MainActivity));
			//}
		}


		public void OnBtnDeleteClick(object sender,EventArgs e)
		{
			try 
			{
				//objDb.DeleteItem(ListId);
				Toast.MakeText(this,"Note Deleted",ToastLength.Long).Show();
				this.Finish();
				StartActivity(typeof(MainActivity));
			} catch (Exception ex) {
				Console.WriteLine ("Error Occurred:" + ex.Message);
			}
		}







	}
}

