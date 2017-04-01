using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoTo.Service.Provider.Interface.Models;
using GoTo.Service.Storage.Intergace.Models;

namespace GoTo.Service.Provider.Models
{
    internal sealed class Offer : IOffer
    {
        public string Title { get; set; }
        public string Description { get; set; }

        internal Offer(OfferDataModel offerDataModel)
        {
            Title = offerDataModel.Title;
            Description = offerDataModel.Description;
        }
    }
}
