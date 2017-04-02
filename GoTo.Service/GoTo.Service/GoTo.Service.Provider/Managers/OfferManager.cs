using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoTo.Service.Provider.Interface.Managers;
using GoTo.Service.Provider.Interface.Models;
using GoTo.Service.Storage.Intergace.Managers;
using GoTo.Service.Provider.Models;

namespace GoTo.Service.Provider.Managers
{
    public sealed class OfferManager : IOfferManager
    {
        private IOffersDataManager _offersDataManager;

        public OfferManager(IOffersDataManager offerDataManager)
        {
            _offersDataManager = offerDataManager;
        }

        public IReadOnlyCollection<IOffer> GetOffers()
        {
            var offersDataModel = _offersDataManager.GetOffers();
            var offers = offersDataModel.Select(p => new Offer(p)).ToList();
            return offers;
        }
    }
}
