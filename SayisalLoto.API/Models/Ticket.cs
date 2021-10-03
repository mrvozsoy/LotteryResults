using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayisalLoto.API.Models
{
    public class Ticket
    {
        public string Month { get; set; }
        public string Year { get; set; }
        public string TicketNumber { get; set; }
        public string LN1 { get; set; }
        public string LN2 { get; set; }
        public string LN3 { get; set; }
        public string LN4 { get; set; }
        public string LN5 { get; set; }
        public string LN6 { get; set; }
        public string Joker { get; set; }
    }
    public class Tickets
    {
        public List<Ticket> DataList { get; set; }
    }
}
