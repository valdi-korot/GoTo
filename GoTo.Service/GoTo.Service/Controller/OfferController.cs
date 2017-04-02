using System.Net.Http;
using System.Web.Http;
using GoTo.Service.Provider.Interface.Managers;

namespace GoTo.Service.Controller
{
    [Authorize]
    public class OfferController : ApiController
    {
        private readonly IOfferManager _offerManager;

        public OfferController(IOfferManager offerManager)
        {
            _offerManager = offerManager;
        }

        [Route("offers")]
        [HttpGet]
        public HttpResponseMessage GetOffers()
        {
            var offers = _offerManager.GetOffers();
            return Request.CreateResponse(offers);
        }
        [Route("offers")]
        [HttpPost]
        public HttpResponseMessage CreateOffer()
        {
            var offers = _offerManager.GetOffers();
            return Request.CreateResponse(offers);
        }
    }
}