using System;
namespace GoTo.Service.Storage.Intergace.Models
{
    public sealed class OfferDataModel
    {
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
    }
}
