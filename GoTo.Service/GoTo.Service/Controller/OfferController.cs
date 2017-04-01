using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using GoTo.Service.Provider.Interface.Managers;

namespace GoTo.Service.Controller
{
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
    }
}