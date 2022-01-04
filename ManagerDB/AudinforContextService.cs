using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using log4net;
using RepositorioDB;
using RepositorioDB.ContextosDB;

namespace ManagerDB
{
    public class AudinforContextService : BaseContextService
    {
        //Librería Log4net 
        ILog Logger = LogManager.GetLogger(typeof(AudinforContextService));


        #region Constructors

        public AudinforContextService()
        {

            ConnectionStringSettings configConectionString = null;

            configConectionString = ConfigurationManager.ConnectionStrings[connectionStringES];


            context = new AudinforContext(CreateDbConnection(configConectionString.ProviderName,
                configConectionString.ConnectionString));
        }

        public AudinforContextService(string connectionStringName)
        {
            ConnectionStringSettings configConectionString = null;

            configConectionString = ConfigurationManager.ConnectionStrings[connectionStringName];

            context = new AudinforContext(CreateDbConnection(configConectionString.ProviderName,
                configConectionString.ConnectionString));
            
            
        }


        #endregion


        #region Methods

        public new void Commit()
        {
            try
            {
                //TODO
                //AUDITAR CAMBIOS


                //TODO
                //AÑADIR VALORES COMUNES USURIO LOGUEADO... etc
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                base.Commit();
            }


        }

        //TODO
        //AUDITAR CAMBIOS


        //TODO
        //AÑADIR VALORES COMUNES USURIO LOGUEADO... etc



        public BaseContext GetContext()
        {
            return context;
        }

        #endregion

        #region Self

        public string GetDbConnected()
        {
            return
                $"ServidorDB: {((System.Data.SqlClient.SqlConnection) context.Database.Connection).DataSource}" +
                $" DataBase: {((System.Data.SqlClient.SqlConnection) context.Database.Connection).Database.ToString()}";
        }


        #endregion

        #region Managers

        private readonly CnaeManager cnaeManager = null;

        public CnaeManager CNAEManager
        {
            get { return cnaeManager ?? new CnaeManager(context); }
        }



        #endregion
    }
}
