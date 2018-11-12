using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLReader.server
{
    public class JobCreator
    {
        public void CreateAllJobs(QuartzServer server)
        {

            try
            {
                #region INSERT NF DB
                var dictionary = new Dictionary<String, DateTime>();
                dictionary.Add("DataVenda", DateTime.Today);

                var jobContaWifi = Quartz.JobBuilder.Create()
                            .OfType(typeof(XMLRead))
                            .StoreDurably(true)
                            .WithDescription("Job NFe Insert DB ")
                            .WithIdentity(new JobKey("Job NFe Insert DB", "main"))
                            .Build();

                //executa a cada 4 minutos
                var triggerContasWifi = TriggerBuilder.Create()
                                    .ForJob(jobContaWifi)
                                    .UsingJobData(new JobDataMap(dictionary))
                                    .UsingJobData("SyncCompleto", false)
                                    .UsingJobData("QtdeItensEnvio", 10000)
                                    .UsingJobData("SyncPeriodo", false)
                                    .WithCronSchedule("	0 0/4 * 1/1 * ? *")
                                    .StartNow()
                                    .Build();

                server.AddTrigger(jobContaWifi, triggerContasWifi);

                #endregion


            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\temp\Service.txt", string.Format("Falha ao iniciar servidor Quartz. {0}.", ex.ToString()));

            }
        }
    }
}
