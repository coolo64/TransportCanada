using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransportCanada.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace TransportCanada.Controllers
{
    public class API1Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromBody]List<Recall> recalls)
        {
            HttpClient HttpClient = new HttpClient();

            //foreach(Recall recall in recalls)
            //{
            Recall recall = recalls[0];
                if (!string.IsNullOrWhiteSpace(recall.recallNumber)) {
                    using (var response = await HttpClient.GetAsync("https://data.tc.gc.ca/v1.3/api/eng/vehicle-recall-database/sommaire-rappel/numero-de-rappel/" + recall.recallNumber + "?format=json"))
                    {
                        if (!response.IsSuccessStatusCode)
                        {
                            return BadRequest("data.tc.gc.ca returned " + response.StatusCode.ToString());
                        }

                        string recalldata = await response.Content.ReadAsStringAsync();
                        recall.MANUFACTURER_RECALL_NO_TXT = JsonConvert.DeserializeObject<List<RecallSummary>>(recalldata).Where(x => x.Name.Equals("MANUFACTURER_RECALL_NO_TXT")).FirstOrDefault()?.Value.Literal;

                    }
                }
            //}
            

            return Json(recalls);
        }
        
    }
}
