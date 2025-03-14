using playwright_nunit.Pages;

namespace playwright_nunit;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class E2ETests : PageTest
{
    [Test]
    public async Task OrderSingleProductTest()
    {
        var loginPage = new LoginPage(Page);
        var productsPage = new ProductsPage(Page);
        var cartPage = new CartPage(Page);
        var checkoutPage = new CheckoutPage(Page);
        var overviewPage = new OverviewPage(Page);
        var confirmationPage = new ConfirmationPage(Page);

        await loginPage.GotoAsync();
        await loginPage.LoginAsync("standard_user", "secret_sauce");
        await productsPage.AddToCartAsync();
        await productsPage.GoToCartAsync();
        await cartPage.CheckoutAsync();
        await checkoutPage.FillDetailsAsync("John", "Doe", "45678");
        await overviewPage.FinishAsync();
        await confirmationPage.VerifyOrderCompletionAsync();
    }

    [Test]
    public async Task OrderTwoProductsTest()
    {
        var loginPage = new LoginPage(Page);
        var productsPage = new ProductsPage(Page);
        var cartPage = new CartPage(Page);
        var checkoutPage = new CheckoutPage(Page);
        var overviewPage = new OverviewPage(Page);
        var confirmationPage = new ConfirmationPage(Page);

        await loginPage.GotoAsync();
        await loginPage.LoginAsync("standard_user", "secret_sauce");
        await productsPage.AddTwoToCartAsync();
        await productsPage.GoToCartAsync();
        await cartPage.CheckoutAsync();
        await checkoutPage.FillDetailsAsync("John", "Doe", "45678");
        await overviewPage.FinishAsync();
        await confirmationPage.VerifyOrderCompletionAsync();
    }
}