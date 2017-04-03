using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTo.Service.Contracts.IncomingContract
{
    public class OfferIncomingContract
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public DateTime MeetDateTime { get; set; }
    }
}
