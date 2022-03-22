using System.Text.Json.Nodes;

namespace PagespeedapiParser
{
    public class Parser
    {

        //public void httpCall(string uri) {
        public async Task httpCall(string uri) {

            using HttpClient client = new()
            {
                BaseAddress = new Uri("https://www.googleapis.com")
            };

            var model = await client.GetAsync($"pagespeedonline/v5/runPagespeed?url={uri}");

            var result = await model.Content.ReadAsStringAsync();

            /*Use this when working on JSON as there is a limit for calls in a day
            //read json from file and parse it
            string result = File.ReadAllText("../../../../garden_perf1.json");
            */

            var result_ = JsonNode.Parse(result);

            Console.WriteLine("Loading experience: " + result_["loadingExperience"]);

            //var resp = JsonSerializer.Deserialize<Model>(result);
            //Console.WriteLine("Loading experience: " + result_["loadingExperience"]);

        }
    }
}
