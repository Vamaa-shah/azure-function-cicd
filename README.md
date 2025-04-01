# Azure Function CICD

This is a simple Azure Function App that demonstrates CI/CD capabilities. The function returns "Hello, world!" when triggered via HTTP.

## Prerequisites

- .NET 6.0 SDK
- Azure Functions Core Tools
- Visual Studio 2022 or VS Code with Azure Functions extension

## Local Development

1. Clone the repository
2. Open the solution in Visual Studio or VS Code
3. Press F5 to run the function locally
4. The function will be available at `http://localhost:7071/api/Function1`

## Function Details

- Name: Function1
- Trigger: HTTP
- Methods: GET, POST
- Response: "Hello, world!" 