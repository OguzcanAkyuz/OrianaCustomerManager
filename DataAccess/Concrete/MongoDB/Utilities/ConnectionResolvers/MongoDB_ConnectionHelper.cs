using Core.Utilities.IoC;
using Core.Utilities.Results;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Concrete.Databases.MongoDB.Utilities.ConnectionResolvers
{
    public class MongoDB_ConnectionHelper : IDatabase_ConnectionHelper
    {
 


        public IDataResult<DatabaseConnectionSettings> CheckDatabaseConnection()
        {


            return new SuccessDataResult<DatabaseConnectionSettings>(new DatabaseConnectionSettings { HostName = $"mongodb://asdasd"});







        }
    }
}
