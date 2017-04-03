using System.Net.Http;
using System.Web.Http;
using GoTo.Service.Provider.Interface.Managers;
using GoTo.Service.Contracts.IncomingContract;
using Microsoft.AspNet.Identity;

namespace GoTo.Service.Controller
{
    //[Authorize]
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
        public HttpResponseMessage CreateOffer(OfferIncomingContract offerIncoming)
        {
            var offer = _offerManager.CreateOffer();
            offer.AuthorID = User.Identity.GetUserId() ?? "SomeId";//delete this when Vlad doing auth tokens
            offer.Title = offerIncoming.Title;
            offer.Description = offerIncoming.Description;
            offer.Longitude = offerIncoming.Longitude;
            offer.Latitude = offerIncoming.Latitude;
            offer.Status = offerIncoming.Status;
            offer.Type = offerIncoming.Type;
            offer.MeetDateTime = offerIncoming.MeetDateTime;
            offer.Save();
            return Request.CreateResponse(offer);
        }
    }
}