using System.Data.Common;
using System.Data.Entity;
using Modelos;
using RepositorioDB.ConfiguracionesDB;

namespace RepositorioDB.ContextosDB
{
public class AudinforContext : BaseContext, IRepositoryContext
    {
        static AudinforContext()
        {
            Database.SetInitializer<AudinforContext>(null);
        }

        #region Constructors
    

        public AudinforContext(DbConnection dbConnection) : base(dbConnection, true)
        {
        }

        #endregion

        #region Methods

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            //Configuraciones
            modelBuilder.Configurations.Add(new CNAEConfiguration());
        }

        #endregion

        #region Collections
        
        public virtual DbSet<CNAE> Users { get; set; }
        
        #endregion

    }
}