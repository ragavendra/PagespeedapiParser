using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;

namespace PagespeedapiParser
{
    public class Parser
    {
        
        public async Task httpCall() {

            //JsonSerializer.Deserialize
            using HttpClient client = new()
            {
                BaseAddress = new Uri("https://www.googleapis.com")
                //BaseAddress = new Uri("https://www.googleapis.com/pagespeedonline/v5/runPagespeed")
                //BaseAddress = new Uri("https://jsonplaceholder.typicode.com")
            };

            //client.Get
            Model? model;

            var model2 = await client.GetAsync("pagespeedonline/v5/runPagespeed?url=http://www.gardensystems.tech");
            //var model3 = await client.GetFromJsonAsync("");

            //var model1 = await client.GetFromJsonAsync<Model?>("pagespeedonline/v5/runPagespeed?url=http://www.gardensystems.tech");
            //model = <>model1

            var result = await model2.Content.ReadAsStringAsync();

            //model.captchaResult
            //Console.WriteLine("Response from Get call is: " + result);

            //Console.WriteLine(model?.captchaResult);
            model = JsonSerializer.Deserialize<Model>(result);
            //model = JsonConverter<Model>(result);

            Console.WriteLine(model?.captchaResult);

        }
    }
}
