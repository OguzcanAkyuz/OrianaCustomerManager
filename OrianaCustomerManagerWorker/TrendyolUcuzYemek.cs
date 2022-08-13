using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OrianaCustomerManagerWorker
{
    public class TrendyolUcuzYemek : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Console.WriteLine("En ucuz yemek salata!");
                await Task.Delay(100, stoppingToken);
            }
        }
    }
}
