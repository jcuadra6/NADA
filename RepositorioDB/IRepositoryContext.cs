using System;

namespace RepositorioDB
{
    public interface IRepositoryContext
    {
        /// <summary>
        /// Obtiene el proveedor de la conexion, para nosotros SqlServer
        /// </summary>
        String Provider { get; }

        /// <summary>
        /// Realiza el submit de todos los datos
        /// </summary>
        void Commit();

        /// <summary>
        /// Realiza la vuelta atras de todos los datos
        /// </summary>
        void Rollback();
    }
}