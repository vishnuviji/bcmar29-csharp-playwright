using Microsoft.Playwright;

namespace playwright_nunit.Pages;

public class CheckoutPage(IPage page)
{
    private readonly IPage _page = page;

    public async Task FillDetailsAsync(string firstName, string lastName, string postalCode)
    {
        await _page.Locator("[data-test=\"firstName\"]").FillAsync(firstName);
        await _page.Locator("[data-test=\"lastName\"]").FillAsync(lastName);
        await _page.Locator("[data-test=\"postalCode\"]").FillAsync(postalCode);
        await _page.Locator("[data-test=\"continue\"]").ClickAsync();
    }
}