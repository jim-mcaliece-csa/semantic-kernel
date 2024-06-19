# AI Platform Development with Azure and .NET Framework

This repository tracks the development efforts of an AI Platform utilizing Azure and the .NET Framework. The core of this development is centered around the Semantic Kernel, an Open Source SDK, with a focus on leveraging its Handlebars planner.

## Features

The AI Platform will include the following functionality:

1. **Generating "Query Embedding"**: Create embeddings for queries to facilitate advanced search capabilities.
2. **Grounding Data**: Define data locations and specify where embeddings will be stored for efficient data management.
3. **Search**: Execute searches by passing queries and referencing grounded data.
4. **Prompt Generation and Maintenance**: Develop and manage prompts for various AI tasks.
5. **Bing Search Plugin**: Integrate Bing Search to enhance the platform's search capabilities.
6. **Dynamic Creation of AI Search**: Create AI search functionality dynamically based on user input and needs.
7. **Document Intelligence - Form Recognizer**: Implement document intelligence using Azure's Form Recognizer service.
8. **Other AI Services**: Incorporate additional AI services to extend the platform's capabilities.
9. **More to come**: Continuous improvements and new features will be added.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Azure Subscription](https://azure.microsoft.com/en-us/free/)
- [Semantic Kernel](https://github.com/microsoft/semantic-kernel)

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/jim-mcaliece-csa/semantic-kernel.git
   cd semantic-kernel
   ```

2. Install the required packages:

   ```bash
   dotnet restore
   ```

3. Set up Azure resources:
   - Create and configure the necessary Azure services (e.g., Form Recognizer, Bing Search, etc.).
   - Update the configuration files with your Azure credentials and resource details.

### Usage

1. Start the application:

   ```bash
   dotnet run
   ```

2. Access the platform through your preferred web browser or API client.

## Contributing

We welcome contributions to enhance the AI Platform. To contribute:

1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature-name
   ```
3. Make your changes and commit them:
   ```bash
   git commit -m "Add feature description"
   ```
4. Push to the branch:
   ```bash
   git push origin feature-name
   ```
5. Create a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For questions or support, please open an issue in this repository or contact the maintainers.

---

We look forward to building a robust AI Platform with your help!
