using System;
using RestSharp;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Weather
{
	public class RESTHandler
	{
		private string url;
		private IRestResponse response;
		private RestRequest request;

		public RESTHandler ()
		{
			url = "";
		}

		public RESTHandler(string lurl)
		{
			url = lurl;
			request = new RestRequest ();
		}

		public void AddParameter(string name, string value)
		{
			if (request != null) {
				request.AddParameter (name, value);
			}
		}

		public OneDay.RootObject ExecuteOneDayRequest()
		{
			var client = new RestClient (url);

			response = client.Execute (request);

			OneDay.RootObject objRoot = new OneDay.RootObject ();
			objRoot = JsonConvert.DeserializeObject<OneDay.RootObject> (response.Content);

			return objRoot;
		}

		public FiveDays.RootObject ExecuteFiveDayRequest()
		{
			var client = new RestClient (url);

			response = client.Execute (request);

			FiveDays.RootObject objRoot = new FiveDays.RootObject ();
			objRoot = JsonConvert.DeserializeObject<FiveDays.RootObject> (response.Content);

			return objRoot;
		}

//
//		public async Task<RootObject> ExecuteRequestAsync()
//		{
//			var client = new RestClient (url);
//			var request = new RestRequest ();
//
//			response = await client.ExecuteTaskAsync (request);
//
//			RootObject objRoot = new RootObject ();
//			objRoot = JsonConvert.DeserializeObject<RootObject> (response.Content);
//
//			return objRoot;
//		}

	}
}

