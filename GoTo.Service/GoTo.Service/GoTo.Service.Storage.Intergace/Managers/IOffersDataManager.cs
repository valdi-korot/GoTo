using GoTo.Service.Storage.Intergace.Models;
using System.Collections.Generic;

namespace GoTo.Service.Storage.Intergace.Managers
{
    public interface IOffersDataManager
    {
        IReadOnlyCollection<OfferDataModel> GetOffers();
    }
}
