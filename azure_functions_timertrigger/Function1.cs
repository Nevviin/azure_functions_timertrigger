using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace azure_functions_timertrigger
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([TimerTrigger("0 * * * * *",RunOnStartup =true)]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            File.AppendAllText("FunctionLog.txt", $"{Environment.NewLine}C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
