using System;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using CroweConsoleApp.Interfaces;

namespace CroweConsoleApp
{

    public class ValueRepository : IValueRepository
    {
        public async Task<string> GetHelloText()
        {
            string answer = "";
            string restSvcAddress = ConfigurationManager.AppSettings["restHostNumber"].ToString();

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:" + restSvcAddress.ToString() + "/");

                    HttpResponseMessage response = await client.GetAsync("api/values");
                    if (response.IsSuccessStatusCode)
                        answer = await response.Content.ReadAsStringAsync();
                }
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
            }


            return answer;
        }
    }
}
