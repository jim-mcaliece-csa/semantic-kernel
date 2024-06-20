using AiPlatform.Settings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace AiPlatform
{
    public class GenerateQueryEmbeddings
    {
        private readonly ILogger<GenerateQueryEmbeddings> _logger;
		private readonly AzureOpenAiSettings _azureOpenAiSettings;

		public GenerateQueryEmbeddings(ILogger<GenerateQueryEmbeddings> logger, AzureOpenAiSettings azureOpenAiSettings)
        {
            _logger = logger;
			_azureOpenAiSettings = azureOpenAiSettings;
		}

        [Function("GetQueryEmbeddings")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
        {
            _logger.LogInformation("Start: GetQueryEmbeddings");
            return new OkObjectResult("Welcome to Azure Functions!");//Commented
        }
    }
}
