using Quartz;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.QuartzTask.Jobs
{
    public class QuartzJob : IJob
    {
        
        public QuartzJob()
        {

        }

        public System.Threading.Tasks.Task Execute(IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
