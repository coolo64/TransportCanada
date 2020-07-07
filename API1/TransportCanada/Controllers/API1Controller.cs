using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransportCanada.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;

namespace TransportCanada.Controllers
{
    public class API1Controller : Controller
    {
        [HttpGet]
        public IActionResult Index(string manRecalNo)
        {
            string pathToJSON = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "json.json");
            string json = "";

            try
            {
                using (FileStream stream = new FileStream(pathToJSON, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        json = reader.ReadToEnd();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                json = "";
            }

            if (!string.IsNullOrWhiteSpace(json))
            {
                List<Recall> recalls = JsonConvert.DeserializeObject<List<Recall>>(json);
                if (!string.IsNullOrWhiteSpace(manRecalNo))
                {
                    recalls = recalls.Where(x => x.MANUFACTURER_RECALL_NO_TXT == manRecalNo).ToList();
                }

                return Json(recalls);
            }


            return Json("Le fichier n'a pas été sauvegardé ou il n'y a pas de contenue.");
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromBody]List<Recall> recalls)
        {
            if(recalls == null || recalls.Count == 0)
            {
                return BadRequest("Il n'y avait pas de contenu dans le corps de la requête.");
            }

            HttpClient HttpClient = new HttpClient();
            HttpClient.DefaultRequestHeaders.Add("User-Agent", "API1 App");
            HttpClient.DefaultRequestHeaders.Add("accept", "application/json");

            foreach(Recall recall in recalls)
            {
            //Recall recall = recalls[0];
                if (!string.IsNullOrWhiteSpace(recall.recallNumber)) {
                    using (var response = await HttpClient.GetAsync("https://data.tc.gc.ca/v1.3/api/eng/vehicle-recall-database/sommaire-rappel/numero-de-rappel/" + recall.recallNumber + "?format=json"))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string recalldata = await response.Content.ReadAsStringAsync();
                            recall.MANUFACTURER_RECALL_NO_TXT = JsonConvert.DeserializeObject<Result>(recalldata).ResultSet.First().Where(x => x.Name.Equals("MANUFACTURER_RECALL_NO_TXT")).FirstOrDefault()?.Value.Literal;
                        }

                    }
                }
            }

            string pathToJSON = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "json.json");
            string json = "";
            using (FileStream stream = new FileStream(pathToJSON, FileMode.OpenOrCreate))
            {
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.NullValueHandling = NullValueHandling.Ignore;
                json = JsonConvert.SerializeObject(recalls, settings);

                using(StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(json);
                }
            }

            return Ok();
        }
        
    }
}
