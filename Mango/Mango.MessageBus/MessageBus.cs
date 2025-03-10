using Azure.Messaging.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Mango.MessageBus
{
    public class MessageBus : IMessasgeBus
    {
        //ideally this should be placed into appsettings
        private string connectionString = "Endpoint=sb://bojanskopljak.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=ZYhrtyOzQId9CH6SEFpXQcz2ZFL2zIfI1+ASbG9QGhQ=";
        public async Task PublishMessage(object message, string topic_queue_Name)
        {
            await using var client = new ServiceBusClient(connectionString);

            ServiceBusSender sender = client.CreateSender(topic_queue_Name);

            var jsonMessage = JsonConvert.SerializeObject(message);
            ServiceBusMessage finalMessage = new ServiceBusMessage(Encoding
                .UTF8.GetBytes(jsonMessage))
            {
                CorrelationId = Guid.NewGuid().ToString(),
            };

            await sender.SendMessageAsync(finalMessage);
            await client.DisposeAsync();
        }
    }
}
