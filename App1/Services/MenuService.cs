using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace App1.Services
{
    class MenuService
    {
        private Adapters.Adaper _adaper = Adapters.Adaper.GetAdaper();

        public async Task<Models.Menu> GetMenu()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(_adaper.GetMenuApi);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringcontent = await response.Content.ReadAsStringAsync();
                Models.Menu menu = JsonConvert.DeserializeObject<Models.Menu>(stringcontent);
                return menu;
            }
            return null;
        }
    }
}
