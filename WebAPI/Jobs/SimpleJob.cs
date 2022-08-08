using Quartz;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace WebAPI.Jobs
{
    public class SimpleJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            var message = $"Simple executed at ${DateTime.Now.ToString()}";
            Debug.WriteLine(message);
        }
    }
}
