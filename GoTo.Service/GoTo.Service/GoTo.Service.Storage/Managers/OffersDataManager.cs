using GoTo.Service.Storage.Intergace.Managers;
using System.Collections.Generic;
using GoTo.Service.Storage.Intergace.Models;
using GoTo.Service.Storage.Context;

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
    }
}
