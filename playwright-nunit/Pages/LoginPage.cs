using Microsoft.Playwright;

namespace playwright_nunit.Pages;

public class LoginPage(IPage page)
{
    private readonly IPage _page = page;

    public async Task GotoAsync()
    {
        await _page.GotoAsync("https://www.saucedemo.com/");
    }

    public async Task LoginAsync(string username, string password)
    {
        await _page.Locator("[data-test=\"username\"]").FillAsync(username);
        await _page.Locator("[data-test=\"password\"]").FillAsync(password);
        await _page.Locator("[data-test=\"login-button\"]").ClickAsync();
    }
}