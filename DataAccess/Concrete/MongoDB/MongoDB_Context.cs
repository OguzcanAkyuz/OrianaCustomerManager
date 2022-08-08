using Core.DataAccess.Databases.MongoDB;
using Core.Entities;
using Core.Utilities.IoC;
using DataAccess.Concrete.MongoDB.Collections;
using DataAccess.Concrete.Databases.MongoDB.Utilities.ConnectionResolvers;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using System;
using System.Threading;

namespace DataAccess.Concrete.Databases.MongoDB
{
    public class MongoDB_Context<TEntity, PredefinedCollection> : IDisposable, IMongoDB_Context<TEntity>
        where PredefinedCollection : class, ICollection, new()
        where TEntity : class, IEntity, new()
    {
        public MongoClient client { get; set; }
        public IMongoDatabase database { get; set; }
        public IMongoCollection<TEntity> collection { get; set; }
        private PredefinedCollection predefinedCollection = new PredefinedCollection();

        public MongoDB_Context()
        {
            GetMongoDBCollection();
        }
        public IMongoCollection<TEntity> GetMongoDBCollection()
        {
        tryAgain:
            try
            {
                    client = new MongoClient("mongodb://localhost:27017");
                    database = client.GetDatabase("CustomerManager");
                    collection = database.GetCollection<TEntity>(predefinedCollection.CollectionName);
                    return collection;
              
            }
            catch (System.Exception)
            {

                Thread.Sleep(15000);
                goto tryAgain;

            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
