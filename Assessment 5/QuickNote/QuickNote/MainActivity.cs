using System;
using System.IO;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.Widget;
using Xamarin.ActionbarSherlockBinding.App;
using SherlockActionBar = Xamarin.ActionbarSherlockBinding.App.ActionBar;
using Xamarin.ActionbarSherlockBinding.Views;
using Tab = Xamarin.ActionbarSherlockBinding.App.ActionBar.Tab;
using FragmentTransaction = Android.Support.V4.App.FragmentTransaction;
using SearchView = Xamarin.ActionbarSherlockBinding.Widget.SearchView;

namespace QuickNote
{
	[Activity (Label = "QuickNote", MainLauncher = true, Icon = "@drawable/Icon")]
	public class MainActivity :  SherlockActivity, SearchView.IOnQueryTextListener
	{
		//int count = 1;

		ListView lstQuickNote;
		List<NoteTable> myList;
		static string dbName = "QuickNote.sqlite";
		string dbPath = Path.Combine (Android.OS.Environment.ExternalStorageDirectory.ToString (), dbName);
		DatabaseManager objDb;
		TextView Search;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			RequestWindowFeature (WindowFeatures.ActionBar);

			SetContentView (Resource.Layout.Main);

			ActionBar.NavigationMode = ActionBarNavigationMode.Standard;
			ActionBar.SetTitle(Resource.String.actionbar_title);
			ActionBar.SetDisplayShowTitleEnabled (true);

			lstQuickNote = FindViewById<ListView> (Resource.Id.listView1);

			CopyDatabase ();

			objDb = new DatabaseManager ();
			myList = objDb.ViewAll ();

			lstQuickNote.Adapter = new DataAdapter (this, myList);
			lstQuickNote.ItemClick += OnlstQuickNoteClick;
			lstQuickNote.ItemLongClick += listView_ItemLongClick;

		}

//		public void OnTxtSearchTextChanged(object sender, Android.Text.TextChangedEventArgs e)
//		{
//			Toast.MakeText (this, Search.Text, ToastLength.Short).Show ();
//		}

		public void OnBtnDeleteClick(int position)
		{
			try 
			{
				objDb.DeleteItem(position);
				Toast.MakeText(this,"Deleted",ToastLength.Long).Show();
				myList = objDb.ViewAll ();
				lstQuickNote.Adapter = new DataAdapter (this, myList);

			} catch (Exception ex) {
				Console.WriteLine ("Error Occurred:" + ex.Message);
			}
		}
			
		private void listView_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
		{
			var ToDoItem = myList[e.Position];
			int ListID = ToDoItem.ListId;
			var menu = new PopupMenu(this, (View)sender);
			menu.Inflate(Resource.Menu.popupmenu);
			menu.MenuItemClick += (s, a) => {
				switch (a.Item.ItemId) {
				case Resource.Id.pm_delete:

					OnBtnDeleteClick (ListID);
					break;
				}
			};
			menu.Show();
		}

		public bool OnQueryTextSubmit (String query)
		{
			Toast.MakeText (this, "You searched for: " + query, ToastLength.Long).Show ();
			return true;
		}

		public bool OnQueryTextChange (String newText)
		{
			return false;
		}

		public override bool OnCreateOptionsMenu(Xamarin.ActionbarSherlockBinding.Views.IMenu menu)
		{
			menu.Add ("Search")
				.SetIcon (Android.Resource.Drawable.IcMenuSearch)
				.SetActionView (Resource.Layout.collapsible_edittext)
				.SetShowAsAction (MenuItem.ShowAsActionIfRoom | MenuItem.ShowAsActionCollapseActionView);

			menu.Add ("Add")
				.SetIcon (Android.Resource.Drawable.IcMenuAdd)
				.SetShowAsAction (MenuItem.ShowAsActionIfRoom | MenuItem.ShowAsActionCollapseActionView);

			return base.OnCreateOptionsMenu (menu);
		}
			
		public void CopyDatabase()
		{
		if (!File.Exists(dbPath))
			{
				using (BinaryReader br = new BinaryReader(Assets.Open(dbName)))
				{
					using (BinaryWriter bw = new BinaryWriter(new FileStream(dbPath, FileMode.Create)))
					{
						byte[] buffer = new byte[2048];
						int len = 0;
						while ((len = br.Read(buffer, 0, buffer.Length)) > 0)
					{
						bw.Write (buffer, 0, len);
					}
					}
				}
			}
		}

		void OnlstQuickNoteClick(object sender, AdapterView.ItemClickEventArgs e)
		{
			var QuickItems = myList[e.Position];
			var EditItem = new Intent (this, typeof(ViewItem));

			EditItem.PutExtra ("Title", QuickItems.Title);
			EditItem.PutExtra ("Details", QuickItems.Details);
			EditItem.PutExtra ("ListID", QuickItems.ListId);

			StartActivity (EditItem);
		}

		protected override void OnResume ()
		{
			base.OnResume ();
			objDb = new DatabaseManager();
			myList = objDb.ViewAll();
			lstQuickNote.Adapter = new DataAdapter(this,myList);
		}

		public override bool OnOptionsItemSelected(Xamarin.ActionbarSherlockBinding.Views.IMenuItem item)
		{
			switch (item.TitleFormatted.ToString())
		{
			case "Add":
				StartActivity (typeof(AddItem));
			break; 
		}
			return base.OnOptionsItemSelected(item);
		}
				
		}
	}


