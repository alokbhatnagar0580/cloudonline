using Microsoft.Azure.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBusPoC
{
    class Program
    {
        const string connectionString = "Endpoint=sb://pocservicebusalok.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=E1fwqbNOwDsFJprpHdsBhCFZ9iYYfO5ndIOHYedXAds="; // get it from azure portal from service bus namespace shared                                                                           //access policy 
        const string queueName = "msgqueue";
        //QueueClient _client; 
        static void Main(string[] args)
        {
           
            MainAsync().GetAwaiter().GetResult();
            GetMessage();
        }
        static async Task MainAsync()
        
            {  
  
        
           //var _client = QueueClient.CreateFromConnectionString(connectionString, queueName);  
           string msg = "I'm in Azure Service Bus Queue";
            Message m = new Message(Encoding.ASCII.GetBytes(msg));
            QueueClient _client = new QueueClient(connectionString, queueName);
            await _client.SendAsync(m);  

           // string body= _client.
  
       }

        static void GetMessage()
        {
          
          
            //message.Complete();
            //message.Abandon();
            //Console.WriteLine(body);
            //Console.ReadLine();

        }
    }
}
