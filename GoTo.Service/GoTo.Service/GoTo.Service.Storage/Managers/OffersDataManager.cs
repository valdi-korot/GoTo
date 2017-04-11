using GoTo.Service.Storage.Intergace.Managers;
using System.Collections.Generic;
using GoTo.Service.Storage.Intergace.Models;
using GoTo.Service.Storage.Context;
using System.Data.SqlClient;
using System;

namespace GoTo.Service.Storage.Managers
{
    public sealed class OffersDataManager : IOffersDataManager
    {
        GoToDbContext db;
        public OffersDataManager(string goToDbConnectionString)
        {
            db = new GoToDbContext(goToDbConnectionString);
        }

        public IReadOnlyCollection<OfferDataModel> GetOffers()
        {
            var dataModel = db.Database.SqlQuery<OfferDataModel>("[GoTo].GetOffers");
            return dataModel.ToArrayAsync().Result;
        }
        public OfferDataModel CreateOffer(OfferDataModel offerDataModel)
        {
            db.Database.ExecuteSqlCommand(
            "EXEC  [GoTo].[CreateOffer]  @id, @title, @description,@Longitude,@Latitude,@AuthorID,@Status," +
            "@Type,@MeetDateTime,@CreatedDateTime",
             new SqlParameter("id", offerDataModel.Id),
             new SqlParameter("title", offerDataModel.Title),
             new SqlParameter("description", offerDataModel.Description),
             new SqlParameter("Longitude", offerDataModel.Longitude),
             new SqlParameter("Latitude", offerDataModel.Latitude),
             new SqlParameter("AuthorID", offerDataModel.AuthorID),
             new SqlParameter("Status", offerDataModel.Status),
             new SqlParameter("Type", offerDataModel.Type),
             new SqlParameter("MeetDateTime", offerDataModel.MeetDateTime),
             new SqlParameter("CreatedDateTime", offerDataModel.CreatedDateTime));
            return offerDataModel;
        }

        public IReadOnlyCollection<OfferDataModel> GetOffersByAuthorId(string AuthorId)
        {
            //IReadOnlyCollection<OfferDataModel> currentOffers = db.Database.ExecuteSqlCommand(
            //"EXEC  [GoTo].[GetOffersByUserId]  @AuthorId",
            //new SqlParameter("AuthorId", offerDataModel.AuthorID));
            //return currentOffers;
            var dataModel = db.Database.SqlQuery<OfferDataModel>("[GoTo].GetOffersByAuthorId @AuthorId" ,new SqlParameter("AuthorId", AuthorId.ToString()));
            return dataModel.ToArrayAsync().Result;
        }

    
    }
}
