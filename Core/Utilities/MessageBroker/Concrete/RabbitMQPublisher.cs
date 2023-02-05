using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.DataAccess.MessageBroker.Concrete
{
       
    public class RabbitMQPublisher
    {
        private readonly ConnectionFactory _factory;
        private IConnection _connection;
        private IModel _channel;
        private ILogger _logger;
        readonly IConfiguration _iConfig;
        private readonly IConfiguration _configuration;
        public static string ExchangeName = "ImageDirectExchange";
        public static string RoutingWatermark = "watermark-route-image";
        public static string QueueName = "meeting-queue";
       

        public RabbitMQPublisher(ConnectionFactory connectionFactory, ILogger<RabbitMQPublisher> logger, IConfiguration iConfig)
        {
            _factory = connectionFactory;
            _logger = logger;
            Connect();
            _iConfig = iConfig;
        }

        public IModel Connect()
        {
            if(_channel is { IsOpen: true })
            {
                return _channel;
            }
            _connection= _factory.CreateConnection();
            using (_channel = _connection.CreateModel()) {
                _channel.ExchangeDeclare(ExchangeName, type: "direct", false);
                _channel.QueueDeclare("control-queue", true, false, false, null);
                _channel.QueueBind(exchange:ExchangeName,queue:QueueName,routingKey:RoutingWatermark);
                _logger.LogInformation("Succes");
                return _channel;
            }
           
        }
        public void Dispose()
        {
            _channel?.Close();
            _channel?.Dispose();
            _channel = default;
            _connection?.Close();
            _connection?.Dispose();
            _logger.LogInformation("Error");
        }


    }
}

