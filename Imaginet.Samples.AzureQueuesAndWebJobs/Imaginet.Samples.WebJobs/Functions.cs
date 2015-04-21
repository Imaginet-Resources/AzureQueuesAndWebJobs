using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imaginet.Samples.Domain;
using Microsoft.Azure.WebJobs;

namespace Imaginet.Samples.WebJobs
{
    public class Functions
    {
        // This function will get triggered/executed when a new message is written 
        // on an Azure Queue called queue.
        public static void ProcessQueueMessage([ServiceBusTrigger("signups")] Person message, TextWriter log)
        {
            log.WriteLine(message.EmailAddress);
        }
    }
}
