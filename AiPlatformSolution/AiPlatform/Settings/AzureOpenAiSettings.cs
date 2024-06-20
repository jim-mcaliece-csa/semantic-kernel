using Microsoft.Extensions.Configuration;

namespace AiPlatform.Settings
{
	public class AzureOpenAiSettings
	{
		public IConfigurationRoot Configuration { get; set; }
		public AzureOpenAiSettings()
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(Environment.CurrentDirectory)
				.AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
				.AddEnvironmentVariables();

			Configuration = builder.Build();
		}

		public string Endpoint => Configuration["AzureOpenAI:ENDPOINT"];
		public string Key => Configuration["AzureOpenAI:API_KEY"];
		public string EmbeddingModel => Configuration["AzureOpenAI:EMBEDDING_DEPLOYED_MODEL"];
		public string gpt35turbo => Configuration["AzureOpenAI:CHAT_MODEL"];

	}
}