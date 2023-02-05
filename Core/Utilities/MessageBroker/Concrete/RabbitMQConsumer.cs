using Core.CrossCuttingConcerns.DataAccess.MessageBroker.Abstract;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver.Core.Bindings;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.CrossCuttingConcerns.DataAccess.MessageBroker.Concrete
{

    public class RabbitMQConsumer : IRabbitMQConsumer
    {
        private IConfiguration _configuration;
        public static void Main()
        {
            var factory = new ConnectionFactory() { Uri = new Uri("amqps://tfwpsyhh:4YrPZWEGj_Mc88n-XN13S6Tu8-X4HK22@shark.rmq.cloudamqp.com/tfwpsyhh") };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "hello",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);

                };
            }
        }
    }
}