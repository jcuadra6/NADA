using System;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using log4net;
using RepositorioDB;

namespace ManagerDB
{
    public abstract class BaseContextService : IDisposable
    {
        protected const string connectionStringES = "FenixContextES";
        protected BaseContext context;
        //Librería Log4net 
        private static readonly ILog Logger = LogManager.GetLogger(typeof(BaseContextService));

        #region Methods

        protected DbConnection CreateDbConnection(string providerName, string connectionString)
        {
            // Assume failure.
            DbConnection connection = null;

            // Create the DbProviderFactory and DbConnection. 
            if (connectionString != null)
            {
                DbProviderFactory factory = DbProviderFactories.GetFactory(providerName);
                connection = factory.CreateConnection();
                if (connection != null) connection.ConnectionString = connectionString;
            }
            
            Logger.Info($"conectado a {connectionString}");
            return connection;
        }

        public void Dispose()
        {
            //Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Commit()
        {
            context.Commit();
            
        }

        public DbContextTransaction BeginTransaction()
        {
            return context.Database.BeginTransaction();
        }
        public DbContextTransaction BeginTransaction(IsolationLevel isolationLevel)
        {
            return context.Database.BeginTransaction(isolationLevel: isolationLevel);
        }

        #endregion
    }
}