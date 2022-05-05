using System.Text.Json.Nodes;
using System.Net;

namespace PagespeedapiParser
{
    public class Parser
    {

        public async Task httpCall(string uri) {

            using HttpClient client = new()
            {
                BaseAddress = new Uri("https://www.googleapis.com")
            };

			var uri_ = $"pagespeedonline/v5/runPagespeed?url={uri}&key=AIzaSyBrPW7A5Cd1hGb0gzaNNf9Nt4LHwjAmoRs";
			//var uri_ = $"pagespeedonline/v5/runPagespeed?url={uri}";
            //Console.WriteLine("Site_: " + uri_);

            var model = await client.GetAsync(uri_);
            var result = await model.Content.ReadAsStringAsync();

            //Console.WriteLine("Loading experience: " + result);

			//if(model.StatusCode != HttpStatusCode.Accepted)
			//	return;
			
            /*Use this when working on JSON as there is a limit for calls in a day
            //read json from file and parse it
            string result = File.ReadAllText("../../../../garden_perf1.json");
            */

            var result_ = JsonNode.Parse(result);

			Console.WriteLine("User experience: ");
			var metrics = result_["loadingExperience"]["metrics"];

			Console.WriteLine("First Contentful Paint: " + metrics["FIRST_CONTENTFUL_PAINT_MS"]["category"]);
			Console.WriteLine("First Input Delay: " + metrics["FIRST_INPUT_DELAY_MS"]["category"]);

			Console.WriteLine("Loading experience: ");
			var audits = result_["lighthouseResult"]["audits"];
			Console.WriteLine("First Contentful Paint: " + audits["first-contentful-paint"]["displayValue"]);
			Console.WriteLine("Speed index: " + audits["speed-index"]["displayValue"]);
			Console.WriteLine("Time To Interactive: " + audits["interactive"]["displayValue"]);
			Console.WriteLine("First Meaningful Paint: " + audits["first-meaningful-paint"]["displayValue"]);

			if(audits["first-cpu-idle"] != null)
				Console.WriteLine("First CPU Idle: " + audits["first-cpu-idle"]["displayValue"]);

			if(audits["estimated-input-latency"] != null)
				Console.WriteLine("Estimated Input Latency: " + audits["estimated-input-latency"]["displayValue"]);

		}

            //var resp = JsonSerializer.Deserialize<Model>(result);
            //Console.WriteLine("Loading experience: " + result_["loadingExperience"]);
	}
}
