using Microsoft.Playwright;

namespace playwright_nunit.Pages;

public class OverviewPage(IPage page)
{
    private readonly IPage _page = page;

    public async Task FinishAsync()
    {
        await _page.Locator("[data-test=\"finish\"]").ClickAsync();
    }
}