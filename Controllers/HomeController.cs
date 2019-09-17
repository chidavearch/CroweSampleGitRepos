using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Configuration;
using CroweSample.Models;

namespace CroweSample.Controllers
{
    /// <summary>
    /// Could pass in a list of IWriters
    /// </summary>
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index(IWriter writer = null)
        {
            string helloText = await GetHelloText();

            if (writer != null)
                writer.WriteMessage(helloText);

            ViewBag.Title = "Home Page";
            ViewBag.Hello = helloText;
            return View();
        }

        private async Task<string> GetHelloText()
        {
            string answer = "";
            string restSvcAddress = ConfigurationManager.AppSettings["restHostNumber"].ToString();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:" + restSvcAddress.ToString() + "/");

                HttpResponseMessage response = await client.GetAsync("api/values");
                if (response.IsSuccessStatusCode)
                    answer = await response.Content.ReadAsStringAsync();
            }

            return answer;     
        }
    }
}
