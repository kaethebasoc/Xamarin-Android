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
using Android.Graphics;
using System.Net;

namespace Weather
{
	[Activity (Label = "Weather", MainLauncher = true, Icon = "@drawable/Icon")]
	public class MainActivity : SherlockActivity

	{
		int count = 0;

		public TextView time_display;
		public TextView date_display;

		TextView txtTemperature;
		TextView Humidity;

		ImageView WeatherIconDay2;
		ImageView WeatherIconDay3;
		ImageView WeatherIconDay4;
		ImageView WeatherIconDay5;

		TextView WeatherIconTxt;

		TextView Day1Description;
		TextView Day2Description;
		TextView Day3Description;
		TextView Day4Description;
		TextView Day5Description;

		TextView Day1MinTemp;
		TextView Day2MinTemp;
		TextView Day3MinTemp;
		TextView Day4MinTemp;
		TextView Day5MinTemp;

		TextView Day1MaxTemp;
		TextView Day2MaxTemp;
		TextView Day3MaxTemp;
		TextView Day4MaxTemp;
		TextView Day5MaxTemp;

		TextView City;

		public int hour;
		public int minute;
		public DateTime date;

		Button btnNext;
		Button btnPrevious;

		string[] CityList = new string[]
		{
			"Auckland",
			"Hamilton",
			"Wellington",
			"Christchurch"
		};

		RESTHandler objRest;

		OneDay.RootObject objRootList;
		FiveDays.RootObject objFiveDayList;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetTheme (Resource.Style.Theme_Sherlock);

			SetContentView (Resource.Layout.Main);

			time_display = FindViewById<TextView> (Resource.Id.timeDisplay);
			date_display = FindViewById<TextView> (Resource.Id.dateDisplay);

			txtTemperature = FindViewById<TextView> (Resource.Id.day1Temp);
			Humidity = FindViewById<TextView> (Resource.Id.Humidity);

			WeatherIconDay2 = FindViewById<ImageView> (Resource.Id.ivday2);
			WeatherIconDay3 = FindViewById<ImageView> (Resource.Id.ivday3);
			WeatherIconDay4 = FindViewById<ImageView> (Resource.Id.ivday4);
			WeatherIconDay5 = FindViewById<ImageView> (Resource.Id.ivday5);

			Day1Description = FindViewById<TextView> (Resource.Id.day1Condition);
			Day2Description = FindViewById<TextView> (Resource.Id.day2Condition);
			Day3Description = FindViewById<TextView> (Resource.Id.day3Condition);
			Day4Description = FindViewById<TextView> (Resource.Id.day4Condition);
			Day5Description = FindViewById<TextView> (Resource.Id.day5Condition);

			Day1MinTemp = FindViewById<TextView> (Resource.Id.day1Min);
			Day2MinTemp = FindViewById<TextView> (Resource.Id.day2Min);
			Day3MinTemp = FindViewById<TextView> (Resource.Id.day3Min);
			Day4MinTemp = FindViewById<TextView> (Resource.Id.day4Min);
			Day5MinTemp = FindViewById<TextView> (Resource.Id.day5Min);

			Day1MaxTemp = FindViewById<TextView> (Resource.Id.day1Max);
			Day2MaxTemp = FindViewById<TextView> (Resource.Id.day2Max);
			Day3MaxTemp = FindViewById<TextView> (Resource.Id.day3Max);
			Day4MaxTemp = FindViewById<TextView> (Resource.Id.day4Max);
			Day5MaxTemp = FindViewById<TextView> (Resource.Id.day5Max);

			City = FindViewById<TextView> (Resource.Id.txtCity);

			hour = DateTime.Now.Hour;
			minute = DateTime.Now.Minute;
			date = DateTime.Today;

			UpdateTime ();
			UpdateDate ();

			btnNext = FindViewById<Button> (Resource.Id.btnNext);
			btnPrevious = FindViewById<Button> (Resource.Id.btnPrevious);

			btnPrevious.Click += OnBtnPreviousClick;
			btnNext.Click += OnBtnNextClick;
			RefreshWeather (count);
			City.Text = CityList[count];

			GetImage(count);
		}

		public override bool OnCreateOptionsMenu(Xamarin.ActionbarSherlockBinding.Views.IMenu menu)
		{
			menu.Add ("Refresh")
				.SetIcon (Resource.Drawable.refresh)
				.SetShowAsAction (MenuItem.ShowAsActionIfRoom | MenuItem.ShowAsActionCollapseActionView);

			return base.OnCreateOptionsMenu (menu);
		}


		public override bool OnOptionsItemSelected(Xamarin.ActionbarSherlockBinding.Views.IMenuItem item)
		{
			switch (item.TitleFormatted.ToString())
			{
			case "Refresh":
				RefreshWeather(count);
				Toast.MakeText(this,"Updated",ToastLength.Short).Show();
			break;
			}
		return base.OnOptionsItemSelected(item);
		}

		public void RefreshWeather (int index )
		{
			try
			{
				objRest = new RESTHandler (@"http://api.openweathermap.org/data/2.5/weather");

				objRest.AddParameter ("q",CityList[index] + ",nz");
				objRest.AddParameter ("APPID","e6f3cfaed833707ec118cc388affc215");
				objRest.AddParameter ("mode","json");
				objRest.AddParameter ("units","metric");

				objRootList = objRest.ExecuteOneDayRequest  ();

				txtTemperature.Text = Math.Round(objRootList.main.temp,2).ToString() + "°C";
				Humidity.Text = objRootList.main.humidity.ToString() + "%";
				Day1Description.Text = objRootList.weather[0].description;
				Day1MinTemp.Text = Math.Round(objRootList.main.temp_min,2).ToString() + "°C";
				Day1MaxTemp.Text = Math.Round(objRootList.main.temp_max,2).ToString() + "°C";

				objRest = new RESTHandler (@"http://api.openweathermap.org/data/2.5/forecast/daily?");

				objRest.AddParameter ("q",CityList[index] + ",nz");
				objRest.AddParameter ("cnt","5");
				objRest.AddParameter ("APPID","e6f3cfaed833707ec118cc388affc215");
				objRest.AddParameter ("mode","json");
				objRest.AddParameter ("units","metric");

				objFiveDayList = objRest.ExecuteFiveDayRequest ();

				Day2Description.Text = objFiveDayList.list[0].weather[0].description;
				Day3Description.Text = objFiveDayList.list[1].weather[0].description;
				Day4Description.Text = objFiveDayList.list[2].weather[0].description;
				Day5Description.Text = objFiveDayList.list[3].weather[0].description;

				Day2MinTemp.Text = objFiveDayList.list[0].temp.min.ToString() + "°C";
				Day3MinTemp.Text = objFiveDayList.list[1].temp.min.ToString() + "°C";
				Day4MinTemp.Text = objFiveDayList.list[2].temp.min.ToString() + "°C";
				Day5MinTemp.Text = objFiveDayList.list[3].temp.min.ToString() + "°C";

				Day2MaxTemp.Text = objFiveDayList.list[0].temp.max.ToString() + "°C";
				Day3MaxTemp.Text = objFiveDayList.list[1].temp.max.ToString() + "°C";
				Day4MaxTemp.Text = objFiveDayList.list[2].temp.max.ToString() + "°C";
				Day5MaxTemp.Text = objFiveDayList.list[3].temp.max.ToString() + "°C";

				GetImage(count);

			} catch (Exception ex) {
				Console.WriteLine ("Error Occurred:" + ex.Message);
			}
		}

		private Bitmap GetImageBitmapFromUrl(string url)
		{
			Bitmap imageBitmap = null;

			using (var webClient = new WebClient())
			{
				var imageBytes = webClient.DownloadData(url);
				if (imageBytes != null && imageBytes.Length > 0)
				{
					imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
				}
			}
			return imageBitmap;
		}

		public void GetImage (int index)
		{
			string imgurl;

			imgurl = "http://openweathermap.org/img/w/" + objFiveDayList.list[0].weather[0].icon + ".png";
			//Koush.UrlImageViewHelper.SetUrlDrawable (WeatherIconDay2, imgurl, Resource.Drawable.clear_day);
			WeatherIconDay2.SetImageBitmap(GetImageBitmapFromUrl(imgurl));
			imgurl = "http://openweathermap.org/img/w/" + objFiveDayList.list[1].weather[0].icon + ".png";
			WeatherIconDay3.SetImageBitmap(GetImageBitmapFromUrl(imgurl));
			imgurl = "http://openweathermap.org/img/w/" + objFiveDayList.list[2].weather[0].icon + ".png";
			WeatherIconDay4.SetImageBitmap(GetImageBitmapFromUrl(imgurl));
			imgurl = "http://openweathermap.org/img/w/" + objFiveDayList.list[3].weather[0].icon + ".png";
			WeatherIconDay5.SetImageBitmap(GetImageBitmapFromUrl(imgurl));
		}

		public void UpdateTime ()
		{
			string time = string.Format ("{0}:{1}", hour, minute.ToString ().PadLeft (2, '0'));
			time_display.Text = time;
		}

		public void UpdateDate ()
		{
			date_display.Text = date.ToString ("d");
		}

		public void OnBtnNextClick (object sender, EventArgs e)
		{ 
			count = count + 1;

			if (count == 4)
				count = 0;

			try {
				
				RefreshWeather (count);

				City.Text = CityList[count];
				Toast.MakeText(this,"Next",ToastLength.Short).Show();

			} catch (Exception ex) {
				Console.WriteLine ("Error Occurred:" + ex.Message);
			}
		}
		
		public void OnBtnPreviousClick (object sender, EventArgs e)
		{ 
			count = count - 1;

			if (count == -1)
				count = 3;

			try{
				RefreshWeather (count);
				City.Text = CityList[count];
				Toast.MakeText(this,"Previous",ToastLength.Short).Show();

			} catch (Exception ex) {
				Console.WriteLine ("Error Occurred:" + ex.Message);
			}
		}

	}
}


