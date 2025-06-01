# CryptoExchange.Backend

This project is the backend component for a crypto currency web application, built using C#. It demonstrates various backend functionalities required for such an application.

**Note:** This backend is intended for demonstration purposes only, showcasing my C# development skills.

## Features

*   Retrieving user orders
*   Fetching account balances
*   Getting market tickers

## Setup

To set up and run this project locally:

1.  **Prerequisites:**
    *   .NET SDK (Specify version if necessary, e.g., .NET 6.0 or later)
    *   A code editor like Visual Studio, VS Code, or JetBrains Rider

2.  **Clone the repository:**
    ```bash
    git clone <repository_url>
    cd CryptoExchange.Backend
    ```
    (Replace `<repository_url>` with the actual GitHub repository URL once uploaded)

3.  **Restore dependencies:**
    ```bash
    dotnet restore
    ```

4.  **Configure the application:
    *   Review `appsettings.json` and `appsettings.Development.json` for any necessary configuration, such as database connection strings or API keys (if applicable).

5.  **Run the application:
    ```bash
    dotnet run
    ```
    The application should start and typically listen on `https://localhost:7214` and `http://localhost:5227` (check the console output for exact URLs).

## Usage

The backend provides the following API endpoints:

*   `GET /Order/list`: Retrieves a list of user orders. Accepts optional query parameters `state` (e.g., "PENDING") and `pair`.
*   `GET /Account/balances`: Retrieves account balances.
*   `GET /Market/tickers`: Retrieves market tickers.

You can use tools like Postman or Swagger UI (if enabled) to interact with these endpoints.

## Contact for Full Project

This repository contains a demonstration version of the backend. For access to the full project or inquiries, please contact:

CALL ME ON +27 
EMAIL JMMTRADING.NET@GMAIL.COM 

 