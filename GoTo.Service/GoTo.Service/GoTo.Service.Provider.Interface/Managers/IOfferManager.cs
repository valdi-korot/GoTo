using System.Collections.Generic;
using GoTo.Service.Provider.Interface.Models;

namespace GoTo.Service.Provider.Interface.Managers
{
    public interface IOfferManager
    {
        IReadOnlyCollection<IOffer> GetOffers();
        IOffer CreateOffer();
    }
}
