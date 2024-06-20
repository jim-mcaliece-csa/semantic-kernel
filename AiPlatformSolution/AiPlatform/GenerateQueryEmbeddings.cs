using AiPlatform.Settings;
using AiPlatform.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Text;

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
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req)
        {
            _logger.LogInformation("Start: GetQueryEmbeddings");
			var body = JsonConvert.DeserializeObject<InputParams>(await ReadBodyAsStringAsync(req.Body));

			return new OkObjectResult("Welcome to Azure Functions!");//Commented
        }

		private async Task<string> ReadBodyAsStringAsync(Stream body)
		{
			using (StreamReader reader = new StreamReader(body, Encoding.UTF8))
			{
				var str = await reader.ReadToEndAsync();
				return str;
			}
		}
	}
}
