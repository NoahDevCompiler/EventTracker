using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp5.DataModells;

namespace WinFormsApp5
{
    public static class Loader
    {
        public static List<EventData>? eventdata;
        public static List<Event>? events;
        public async static Task Loading()
        {
            DataModells.EventData eventdata = null;
            try
            {
                string json = await Forms.Network.GetData();
                eventdata = JsonConvert.DeserializeObject<DataModells.EventData>(json);
                events = eventdata.Events;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Abrufen der Daten: " + ex.Message);
            }
            
        }
    }
}
