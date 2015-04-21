using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imaginet.Samples.Domain;
using Microsoft.ServiceBus.Messaging;

namespace Imaginet.Samples.Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["AzureWebJobsServiceBus"].ConnectionString;
            var client = QueueClient.CreateFromConnectionString(connectionString, "signups");
            var person = new Person { Name = "James Chambers", EmailAddress = "jamesc@imaginet.com" };
            client.Send(new BrokeredMessage(person));
        }
    }
}
