using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayisalLoto.API.Models
{
    public class ReturnModel
    {
        public string Month { get; set; }
        public string Year { get; set; }
        public string TicketNumber { get; set; }
        public string LuckyNumbers { get; set; }
    }
}
