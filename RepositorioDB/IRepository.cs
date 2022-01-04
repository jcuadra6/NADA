using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RepositorioDB
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Obtiene el valor del contexto
        /// </summary>
        DbContext Context { get; }

        /// <summary>
        /// Obtiene el proveedor de la conexion, para nosotros SqlServer
        /// </summary>
        string Provider { get; }

        /// <summary>
        /// Obtiene todos los registros
        /// </summary>
        /// <returns>IQueryable value</returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Añade un registro al repositorio
        /// </summary>
        /// <param name="item">Registro a añadir</param>
        void Insert(T item);

        /// <summary>
        /// Inserta una lista de registros en el repositorio
        /// </summary>
        /// <param name="entities">Lista de registros a añadir</param>
        void InsertRange(IEnumerable<T> entities);

        /// <summary>
        /// Elimina un registro del repositorio
        /// </summary>
        /// <param name="item">Registro a eliminar</param>
        void Delete(T item);

        /// <summary>
        /// Elimina una lista de registros del repositorio
        /// </summary>
        /// <param name="entities">Lista de registros a eliminar</param>
        void DeleteRange(IEnumerable<T> entities);

        /// <summary>
        /// Crear un registro en el repositorio
        /// </summary>
        /// <returns>Nuevo registro creado</returns>
        T Create();

        /// <summary>
        /// Obtiene el registro por Id
        /// </summary>
        /// <param name="id">Id del registro</param>
        ///<returns>Registro del repositorio, no se devuelve con cargas de objetos asociados</returns>
        T GetById(int id);

        /// <summary>
        /// Ejecuta una SQL y devuelve una lista de registros
        /// </summary>
        /// <param name="nativeSqlQuery"> SQL a ejecutar</param>
        /// <returns>Lista de registros </returns>
        IEnumerable<T> GetFromSqlQuery(string nativeSqlQuery);

        /// <summary>
        /// Ejecuta una SQL y devuelve un entero, para devolver valores de secuencias
        /// </summary>
        /// <param name="nativeSqlQuery"> SQL a ejecutar</param>
        /// <returns>Númer en la secuencia</returns>
        IEnumerable<int> GetSeqSqlQuery(string nativeSqlQuery);
    }
}