using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FunctionAppSharebook
{
    public class FunctionMsgAgendada
    {
        private readonly ILogger _logger;

        public FunctionMsgAgendada(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<FunctionMsgAgendada>();
        }

        [Function(nameof(FunctionMsgAgendada))]
        public void Run([TimerTrigger("*/5 * * * * *")] TimerInfo myTimer)
        {
            _logger.LogInformation($"Acompanhem a comunidade Sharebook no YouTube!");
            
            if (myTimer.ScheduleStatus is not null)
            {
                _logger.LogInformation($"Proxima execucao: {myTimer.ScheduleStatus.Next}");
            }
        }
    }
}
