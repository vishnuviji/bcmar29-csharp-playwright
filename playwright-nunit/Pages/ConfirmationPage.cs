using Microsoft.Playwright;

namespace playwright_nunit.Pages;

public class ConfirmationPage(IPage page)
{
    private readonly IPage _page = page;

    public async Task VerifyOrderCompletionAsync()
    {
        await Assertions.Expect(_page.Locator("[data-test=\"complete-header\"]")).ToContainTextAsync("Thank you for your order!");
    }
}