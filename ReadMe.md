# CSharp Playwright NUnit Tests

This project demonstrates how to use Playwright with NUnit for end-to-end testing of web applications using C#.

## Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)

## Setup

1. Clone the repository:
    ```sh
    git clone <repository-url>
    cd playwright-nunit
    ```

2. Restore the dependencies:
    ```sh
    dotnet restore
    ```

3. Install Playwright browsers:
    ```sh
    pwsh bin/Debug/netX/playwright.ps1 install 
    ```

## Project Structure

The project structure is as follows:
```
/playwright-nunit
    /Pages
        LoginPage.cs
        ProductsPage.cs
        CartPage.cs
        CheckoutPage.cs
        OverviewPage.cs
        ConfirmationPage.cs
    UnitTest1.cs
    UnitTest2.cs
    // ...other test files...
```

## Writing Tests

To write a new test, create a new method in one of the test files or create a new test file. Each test method should follow the pattern of navigating through the pages and performing actions.

Example:
```csharp
[Test]
public async Task NewTest()
{
    var loginPage = new LoginPage(Page);
    var productsPage = new ProductsPage(Page);
    // ...initialize other pages...

    await loginPage.GotoAsync();
    await loginPage.LoginAsync("username", "password");
    // ...perform other actions...
}
```

Make sure to follow the existing patterns and naming conventions for consistency.

## Running Tests

To run the tests, use the following command:
```sh
dotnet test
```

## Generating Test Reports

To generate test reports, you can use the `--logger` option with the `dotnet test` command. For example, to generate an HTML report, use:
```sh
dotnet test --logger "html;LogFileName=TestResults.html"
```

You can also generate other types of reports such as TRX or XML by specifying the appropriate logger.