using System;
using System.IO;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Database;
using Android.OS;
using Android.Provider;
using Android.Views;
using Android.Widget;
using Android.Support.V4.Widget;
using Xamarin.ActionbarSherlockBinding;
using Xamarin.ActionbarSherlockBinding.App;
using Xamarin.ActionbarSherlockBinding.Views;
using Xamarin.ActionbarSherlockBinding.Widget;
using SherlockActionBar = Xamarin.ActionbarSherlockBinding.App.ActionBar;
using SearchView = Xamarin.ActionbarSherlockBinding.Widget.SearchView;
using CursorAdapter = Android.Support.V4.Widget.CursorAdapter;
using IMenu = Xamarin.ActionbarSherlockBinding.Views.IMenu;
using Android.Runtime;

namespace QuickNote
{
	[Activity (Label = "search_views")]
	[IntentFilter (new string [] { Intent.ActionMain })]
	public class SearchViews : SherlockActivity, SearchView.IOnQueryTextListener,
	SearchView.IOnSuggestionListener
	{
		static readonly string[] COLUMNS = new string[] {
			BaseColumns.Id,
			SearchManager.SuggestColumnText1,
		};
		private SuggestionsAdapter mSuggestionsAdapter;

		public override bool OnCreateOptionsMenu (IMenu menu)
		{
			//Used to put dark icons on light action bar
			//bool isLight = SampleList.THEME == Resource.Style.Sherlock___Theme_Light;

			//Create the search view
			SearchView searchView = new SearchView (SupportActionBar.ThemedContext);
			searchView.QueryHint = "Search for countries…";
			searchView.SetOnQueryTextListener (this);
			searchView.SetOnSuggestionListener (this);

			if (mSuggestionsAdapter == null) {
				MatrixCursor cursor = new MatrixCursor (COLUMNS);
				Converter<string, Java.Lang.Object> func = s => new Java.Lang.String (s);
				cursor.AddRow (Array.ConvertAll<string,Java.Lang.Object> (new string[] { "1", "'Murica" }, func));
				cursor.AddRow (Array.ConvertAll<string,Java.Lang.Object> (new string[] { "2", "Canada" }, func));
				cursor.AddRow (Array.ConvertAll<string,Java.Lang.Object> (new string[] { "3", "Denmark" }, func));
				mSuggestionsAdapter = new SuggestionsAdapter (SupportActionBar.ThemedContext, cursor);
			}

			searchView.SuggestionsAdapter = mSuggestionsAdapter;

			menu.Add ("Search")
				.SetIcon (  Resource.Drawable.search)
				.SetActionView (searchView)
				.SetShowAsAction (MenuItem.ShowAsActionIfRoom | MenuItem.ShowAsActionCollapseActionView);

			return true;
		}

		protected override void OnCreate (Bundle savedInstanceState)
		{
			//SetTheme (SampleList.THEME); //Used for theme switching in samples
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Search);
			//FindViewById<TextView> (Resource.Id.text).SetText (Resource.String.search_views_content);
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

		public bool OnSuggestionSelect (int position)
		{
			return false;
		}

		public bool OnSuggestionClick (int position)
		{
			var c = (ICursor) mSuggestionsAdapter.GetItem (position);
			String query = c.GetString (c.GetColumnIndex (SearchManager.SuggestColumnText1));
			Toast.MakeText (this, "Suggestion clicked: " + query, ToastLength.Long).Show ();
			return true;
		}

		private class SuggestionsAdapter : CursorAdapter
		{

			public SuggestionsAdapter (Context context, ICursor c) 
				: base (context, c, 0)
			{
			}

			public override View NewView (Context context, ICursor cursor, ViewGroup parent)
			{
				LayoutInflater inflater = LayoutInflater.From (context);
				View v = inflater.Inflate (Android.Resource.Layout.SimpleListItem1, parent, false);
				return v;
			}

			public override void BindView (View view, Context context, ICursor cursor)
			{
				TextView tv = (TextView)view;
				int textIndex = cursor.GetColumnIndex (SearchManager.SuggestColumnText1);
				tv.Text = cursor.GetString (textIndex);
			}
		}
	}
}
