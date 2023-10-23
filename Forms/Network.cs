using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5.Forms
{
    public static class Network
    {
        public static async Task<string> GetData()
        {

            string APIUrl = "https://eonet.gsfc.nasa.gov/api/v3/events";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(APIUrl);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return json;
                }
                else
                {
                    return response.StatusCode.ToString();
                }

            }
        }
    }
}
