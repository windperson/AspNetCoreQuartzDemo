using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Quartz;

namespace AspNetCoreQuartzDemo.ScheduleJobs
{
    public class DemoScheduledJob : IJob
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<DemoScheduledJob> _logger;

        public DemoScheduledJob(IConfiguration configuration, ILogger<DemoScheduledJob> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation($"Hello from schduled task {DateTime.Now.ToLongTimeString()}");

            await Task.CompletedTask;
        }
    }
}