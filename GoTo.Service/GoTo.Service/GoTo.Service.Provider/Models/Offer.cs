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
        public Guid Id { get; set; }
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
            Id = offerDataModel.Id;
        }
        internal Offer(IOffersDataManager offerDataManager)
        {
            dataManager = offerDataManager;
            Id = Guid.NewGuid();
            CreatedDateTime = DateTime.Now;
        }

        public void Save()
        {
            dataManager.CreateOffer(new OfferDataModel {Id=Id, AuthorID = AuthorID, Description = Description,
                Latitude = Latitude, Longitude = Longitude,CreatedDateTime=CreatedDateTime, MeetDateTime = MeetDateTime, Status = Status,
                Title = Title, Type = Type });
        }

    }
}
