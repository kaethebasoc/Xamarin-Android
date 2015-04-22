using System;
using Android.App;
using Android.Runtime;
using Parse;

namespace ToDoListUsingParse
{
	[Application]
	public class App : Application
	{
		public App (IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		public override void OnCreate ()
		{
			base.OnCreate ();

			// Initialize the Parse client with your Application ID and .NET Key found on
			// your Parse dashboard
			ParseClient.Initialize ("jTYWuukRkPrjLrUl26OZXj0aS2gXpS5mV3buWwSp", "w60h0z0MmHFFAkAEf7Ieb7bMY5f24dU5wC6ctPjM");
		}
	}
}

