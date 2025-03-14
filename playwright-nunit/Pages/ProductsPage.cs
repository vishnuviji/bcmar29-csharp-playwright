using Microsoft.Playwright;

namespace playwright_nunit.Pages;

public class ProductsPage(IPage page)
{
    private readonly IPage _page = page;

    public async Task AddToCartAsync()
    {
        await _page.Locator("[data-test=\"add-to-cart-sauce-labs-backpack\"]").ClickAsync();
    }

    public async Task AddTwoToCartAsync()
    {
        await AddToCartAsync();
        await _page.Locator("[data-test=\"add-to-cart-sauce-labs-bike-light\"]").ClickAsync();
    }

    public async Task GoToCartAsync()
    {
        await _page.Locator("[data-test=\"shopping-cart-link\"]").ClickAsync();
    }
}