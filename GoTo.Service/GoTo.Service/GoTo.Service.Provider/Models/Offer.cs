using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoTo.Service.Provider.Interface.Models;
using GoTo.Service.Storage.Intergace.Models;
using GoTo.Service.Storage.Intergace.Managers;

namespace GoTo.Service.Provider.Models
{
    internal sealed class Offer : IOffer
    {
        private readonly IOffersDataManager dataManager;
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string AuthorID { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public DateTime MeetDateTime { get; set; }
        public DateTime CreatedDateTime { get; set; }
        internal Offer(OfferDataModel offerDataModel)
        {
            Title = offerDataModel.Title;
            Description = offerDataModel.Description;
            Longitude = offerDataModel.Longitude;
            Latitude = offerDataModel.Latitude;
            AuthorID = offerDataModel.AuthorID;
            Status = offerDataModel.Status;
            Type = offerDataModel.Type;
            MeetDateTime = offerDataModel.MeetDateTime;
            CreatedDateTime = offerDataModel.CreatedDateTime;
        }
        internal Offer()
        {
            Id = Guid.NewGuid().ToString();
            CreatedDateTime = DateTime.Now;
        }

        public void Save()
        {
            dataManager.InsertOffer(new OfferDataModel { AuthorID = AuthorID, Description = Description,
                Latitude = Latitude, Longitude = Longitude, MeetDateTime = MeetDateTime, Status = Status,
                Title = Title, Type = Type });
        }

    }
}
