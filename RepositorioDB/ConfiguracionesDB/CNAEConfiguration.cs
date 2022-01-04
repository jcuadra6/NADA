using System.Data.Entity.ModelConfiguration;
using Modelos;

namespace RepositorioDB.ConfiguracionesDB
{
    public class CNAEConfiguration : EntityTypeConfiguration<CNAE>
    {

        private string TableName = "CNAE";

        public CNAEConfiguration()
        {
            //Especificamos PK y tabla
            HasKey(x => x.IdCNAE)
                .ToTable(TableName);

            Property(x => x.CodigoCNAE)
                .HasColumnName("CodigoCNAE")
                .IsRequired();

            Property(x => x.Entorno)
                .HasColumnName("Entorno");

            Property(x => x.CodigoAgrupacion)
                .HasColumnName("CodigoAgrupacion");

            Property(x => x.DescripcionCodigoAgrupacion)
                .HasColumnName("DescripcionCodigoAgrupacion");

            Property(x => x.TextoCNAE)
                .HasColumnName("TextoCNAE");

        }
    }
}