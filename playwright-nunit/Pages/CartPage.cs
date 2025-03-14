using Microsoft.Playwright;

namespace playwright_nunit.Pages;

public class CartPage(IPage page)
{
    private readonly IPage _page = page;

    public async Task CheckoutAsync()
    {
        await _page.Locator("[data-test=\"checkout\"]").ClickAsync();
    }
}