using System;
using System.Configuration;
using System.Data;
using System.Linq;
using log4net;
using log4net.Config;
using ManagerDB;
using Modelos;
using NUnit.Framework;
using RepositorioDB.ContextosDB;

namespace ContextDbTest
{
    [TestFixture]
    public class Tests
    {
        private AudinforContextService contexto = new AudinforContextService("Context");
        private static readonly ILog log = LogManager.GetLogger(typeof(Tests));

        [Test]

        public void Test2()
        {
            using (var transaccion = contexto.BeginTransaction(IsolationLevel.ReadUncommitted))
            {
                //InitLog4NetConfig();
                log.Info("INICIO");
                CNAE cuentaCnaes = contexto.CNAEManager.GetByCnaeId("1042");


                cuentaCnaes.DescripcionCodigoAgrupacion = "TEST CNAE3";

                CNAE cuentaCnaes2 = contexto.CNAEManager.GetByCnaeId("1042");
                contexto.Commit();
                transaccion.Commit();

                Assert.True(cuentaCnaes.IdCNAE == 1042);
            }

            log.Info("FIN.");



        }

        private static void InitLog4Net()
        {
            // Set up a simple configuration that logs on the console.
            BasicConfigurator.Configure();
        }
    }
}