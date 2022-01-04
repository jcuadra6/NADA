using System;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using log4net;

namespace RepositorioDB
{
    public abstract class BaseContext : DbContext
    {
        
        private const string SCHEMA_DBO = "dbo";
        private const string providerName = "System.Data.SqlClient";
        
        //Librería Log4net 
        private static readonly ILog Logger = LogManager.GetLogger(typeof(BaseContext));
        
        public BaseContext(DbConnection dbConnection, bool owner) : base(dbConnection, owner = true)
        {
            Configure();
        }

        #region Properties

        public string Provider
        {
            get { return providerName; }
        }

        #endregion

        #region Methods

        public void Commit()
        {
            int retryCount = 0;

            while (retryCount < 3)
            {
                try
                {
                    Random espera = new Random();
                    Thread.Sleep(espera.Next(200, 1000));
                    SaveChanges();
                    break;
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    /*
                    foreach (var entry in ex.Entries)
                    {
                        if (entry.Entity is PersonAccount)
                        {
                            var proposedValues = entry.CurrentValues;
                            var databaseValues = entry.GetDatabaseValues();

                            foreach (var property in proposedValues.PropertyNames)
                            {
                                var proposedValue = proposedValues[property];
                                var databaseValue = databaseValues[property];

                                // TODO: decide which value should be written to database
                                // proposedValues[property] = <value to be saved>;
                            }

                            // Refresh original values to bypass next concurrency check
                            entry.OriginalValues.SetValues(databaseValues);
                        }
                        else
                        {
                            throw new NotSupportedException(
                                "Don't know how to handle concurrency conflicts for "
                                + entry.Entity.ToString());
                        }
                    }
                    */
                    
                    // Update the values of the entity that failed to save from the store
                    //ex.Entries.Single().GetDatabaseValues();
                    
                    // Update original values from the database 
                    var entry = ex.Entries.Single();
                    entry.OriginalValues.SetValues(entry.GetDatabaseValues()); 
                    
                    throw new DbUpdateConcurrencyException("Error Concurrencia al actualizar el registro ", ex);
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException is UpdateException &&
                        ex.InnerException.InnerException is SqlException &&
                        (((SqlException) ex.InnerException.InnerException).Number == 1205 && retryCount < 2))
                        retryCount++;
                    else
                        throw;
                }
                catch (Exception ex)
                {
                    retryCount++;
                    throw new Exception("Error en commit", ex);
                }
            }
        }

        public void Rollback()
        {
            Dispose();
        }

        private void Configure()
        {
            Database.Log = (dbLog => Logger.Debug(dbLog.Trim()));            
        }
        

        #endregion
    }
}