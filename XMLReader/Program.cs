using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLReader
{
    class Program
    {
        static void Main(string[] args)
        {

            server.QuartzServer quartzServer;

            try
            {
                quartzServer = new server.QuartzServer();
                quartzServer.StartServer();
                new server.JobCreator().CreateAllJobs(quartzServer);

                System.IO.File.AppendAllText(@"c:\temp\Service.txt", string.Format(@"Serviço de sincronizãção iniciado em {0}.", DateTime.Now.ToString("dd/MM hh:mm:ss")));

            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText(@"c:\temp\Service.txt", string.Format("Falha ao iniciar o serviço. {0}.", ex.ToString()));
                Console.WriteLine("Falha ao iniciar o serviço. {0}.", ex.ToString());
            }

            //new XMLRead().DeserializeXML();

        }
    }
}
