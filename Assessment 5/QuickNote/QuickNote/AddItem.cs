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
	[Activity (Label = "Add Item", Icon = "@drawable/Icon")]			
	public class AddItem : Activity
	{
		Button btnSave;
		Button btnCancel;
		EditText txtAddTitle;
		EditText txtAddDescription;

		DatabaseManager objDb = new DatabaseManager();

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.AddItem);

			btnSave = FindViewById<Button> (Resource.Id.btnSave);
			btnCancel = FindViewById<Button> (Resource.Id.btnCancel);
			txtAddTitle = FindViewById<EditText> (Resource.Id.txtAddTitle);
			txtAddDescription = FindViewById<EditText> (Resource.Id.txtAddDescription);

			btnSave.Click += OnBtnSaveClick;
			btnCancel.Click += OnBtnbtnCancel;
		}

		private void OnBtnSaveClick(object sender,EventArgs e)
		{
			if (txtAddTitle.Text != "" && txtAddDescription.Text != "")
			{
				objDb.AddItem (txtAddTitle.Text, txtAddDescription.Text);
				Toast.MakeText (this, "Note Added", ToastLength.Short).Show();
				this.Finish ();
				StartActivity (typeof(MainActivity));
			}
		}

		public void OnBtnbtnCancel(object sender,EventArgs e)
		{
			try
			{
				Toast.MakeText(this,"Cancelled",ToastLength.Short).Show();
				this.Finish();
				StartActivity(typeof(MainActivity));
			} catch (Exception ex) {
				Console.WriteLine ("Error Occurred:" + ex.Message);
			}
		}

	}
}

