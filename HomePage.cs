using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;

namespace Lab4
{
    class HomePage : AbstractPage
    {
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'All Products')]")]
        public IWebElement product;

        public void AllProducts()
        {
            product.Click();
        }
    }
}
