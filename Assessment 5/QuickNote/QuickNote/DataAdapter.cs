//using System;
//using System.Collections.Generic;
//using Android.App;
//using Android.Content;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using Android.OS;
//using Android.Graphics.Bitmap;

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
using Java.Net;
using Android.Graphics;
using Java.IO;
using Android.Graphics.Drawables;
using Android.Util;
using System.Net;
using System.IO;


namespace QuickNote
{

	public class DataAdapter : BaseAdapter<NoteTable>
	{

		List<NoteTable> items;

		Activity context;
		public DataAdapter(Activity context, List<NoteTable> items)
			: base()

		{
			this.context = context;
			this.items = items;
		}

		public override long GetItemId(int position)
		{
			return position;
		}

		public override NoteTable this[int position]
		{
			get { return items[position]; }
		}

		public override int Count
		{
			get { return items.Count; }
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var item = items[position];
			View view = convertView;
			if (view == null) // no view to re-use, create new
				view = context.LayoutInflater.Inflate(Resource.Layout.CustomRow, null);

			view.FindViewById<TextView>(Resource.Id.lbltitle).Text = item.Title;
			view.FindViewById<TextView> (Resource.Id.lbldate).Text = item.Date.ToString();
			return view;
		}
			
	}
}
