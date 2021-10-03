using Newtonsoft.Json;
using SayisalLoto.API.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SayisalLoto.API.DataLayer
{
    public class Data
    {
        public Tickets LoadAndGetJson()
        {
            using (StreamReader r = new StreamReader( $"{Directory.GetCurrentDirectory()}/Data.json"))
            {
                string json = r.ReadToEnd();
                Tickets items = JsonConvert.DeserializeObject<Tickets>(json);
                return items;
            }
        }
    }
    
}
