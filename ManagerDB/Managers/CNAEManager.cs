using System.Data.Entity;
using System.Linq;
using Modelos;
using RepositorioDB;

namespace ManagerDB
{
    public class CnaeManager : Repository<CNAE>
    {
        #region Constructors

        public CnaeManager(DbContext dbContext) : base(dbContext)
        {
            _log.Info("Instancio el manager de CNAE");
        }

        #endregion

        public override IQueryable<CNAE> GetAll()
        {
            return base.GetAll();
        }


        public CNAE GetByCnaeId(string codigoCnae)
        {
            return GetAll().FirstOrDefault(x => x.CodigoCNAE == codigoCnae);
        }

        

    }
}