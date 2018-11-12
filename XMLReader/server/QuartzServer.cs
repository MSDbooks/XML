using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLReader.server
{
    public class QuartzServer
    {
        private IScheduler scheduler;
        public IScheduler Scheduler
        {
            get { return scheduler; }
        }

        public async void StartServer()
        {
            try
            {

                scheduler = await StdSchedulerFactory.GetDefaultScheduler();

                await scheduler.Start();
                Console.WriteLine("Serviço iniciado.");

            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\temp\Service.txt", string.Format("Falha ao iniciar servidor Quartz. {0}.", ex.ToString()));
                throw;
            }

        }


        public void AddTrigger(IJobDetail Job, ITrigger Trigger)
        {
            scheduler.ScheduleJob(Job, Trigger);
        }


        public void StopServer(bool waitForJobsToComplete)
        {
            this.scheduler.Shutdown(waitForJobsToComplete);
        }
    }
}
