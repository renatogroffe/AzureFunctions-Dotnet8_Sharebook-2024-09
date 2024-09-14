using System;
using Azure.Storage.Queues.Models;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FunctionAppSharebook
{
    public class FunctionExemploMensageria
    {
        private readonly ILogger<FunctionExemploMensageria> _logger;

        public FunctionExemploMensageria(ILogger<FunctionExemploMensageria> logger)
        {
            _logger = logger;
        }

        [Function(nameof(FunctionExemploMensageria))]
        public void Run([QueueTrigger("queue-sharebook", Connection = "AzureWebJobsStorage")] QueueMessage message)
        {
            _logger.LogInformation($"Valor que consta na mensage: {message.MessageText}");
        }
    }
}
