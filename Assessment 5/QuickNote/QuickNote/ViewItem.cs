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

using Android.Support.V4.Widget;
using Xamarin.ActionbarSherlockBinding.App;
using SherlockActionBar = Xamarin.ActionbarSherlockBinding.App.ActionBar;
using Xamarin.ActionbarSherlockBinding.Views;
using Tab = Xamarin.ActionbarSherlockBinding.App.ActionBar.Tab;
using FragmentTransaction = Android.Support.V4.App.FragmentTransaction;
using SearchView = Xamarin.ActionbarSherlockBinding.Widget.SearchView;

namespace QuickNote
{
	[Activity (Label = "View Item", Icon = "@drawable/Icon")]			
	public class ViewItem : SherlockActivity
	{
		int ListId;
		string Title;
		string Details;

		TextView txtTitle;
		TextView txtDetails;

		List<NoteTable> myList;

		Button btnEdit;
		Button btnCancel;
		DatabaseManager objDb;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.ViewItem);
		
			txtTitle = FindViewById<TextView> (Resource.Id.txtEditTitle);
			txtDetails = FindViewById<TextView> (Resource.Id.txtEditDescription);

			btnEdit = FindViewById<Button> (Resource.Id.btnEdit);
			btnCancel = FindViewById<Button> (Resource.Id.btnCancel);

			btnEdit.Click += OnBtnEditClick;
			btnCancel.Click += OnBtnbtnCancel;

			ListId = Intent.GetIntExtra("ListID",0);
			Details = Intent.GetStringExtra("Details");
			Title = Intent.GetStringExtra("Title");

			txtTitle.Text = Title;
			txtDetails.Text = Details;

			objDb = new DatabaseManager();
		}

		public override bool OnCreateOptionsMenu (Xamarin.ActionbarSherlockBinding.Views.IMenu menu)
		{
			menu.Add ("Previous")
				.SetIcon (Resource.Drawable.previous)
				.SetShowAsAction (MenuItem.ShowAsActionIfRoom | MenuItem.ShowAsActionCollapseActionView);

			menu.Add ("Next")
				.SetIcon (Resource.Drawable.next)
				.SetShowAsAction (MenuItem.ShowAsActionIfRoom | MenuItem.ShowAsActionCollapseActionView);

			return true;
		}

		public override bool OnOptionsItemSelected(Xamarin.ActionbarSherlockBinding.Views.IMenuItem item)
		{
			switch (item.TitleFormatted.ToString())
			{
		
			case "Previous":
				OnBtnPreviousClick();
				break;

			case "Next":
				OnBtnNextClick ();
				break;
			}
			return base.OnOptionsItemSelected(item);
		}

		public void OnBtnNextClick()
		{ 
			ListId = ListId + 1;
			try
			{
				myList = objDb.MoveNext(ListId);
				var ToDoItem = myList[0];
				txtTitle.Text = ToDoItem.Title;
				txtDetails.Text = ToDoItem.Details;
				Toast.MakeText(this,"Next Note",ToastLength.Short).Show();

			} catch (Exception ex) {
				Console.WriteLine ("Error Occurred:" + ex.Message);
			}
		}

		public void OnBtnPreviousClick()
		{
			ListId = ListId - 1;
			try{
				myList= objDb.MoveNext(ListId);
				var ToDoItem = myList[0];
				txtTitle.Text = ToDoItem.Title;
				txtDetails.Text = ToDoItem.Details;

				Toast.MakeText(this,"Previous Note",ToastLength.Short).Show();

			} catch (Exception ex) {
				Console.WriteLine ("Error Occurred:" + ex.Message);
			}
		}

		public void OnBtnEditClick(object sender,EventArgs e)
		{
			try 
			{
				objDb.EditItem(txtTitle.Text,txtDetails.Text,ListId);
				Toast.MakeText(this,"Edited",ToastLength.Short).Show();
				this.Finish();
				StartActivity(typeof(MainActivity));

			} catch (Exception ex) {
				Console.WriteLine ("Error Occurred:" + ex.Message);
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