using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitProject1
{
    public class GoogleSearchHome
    {
        IWebDriver driver;

        IWebElement SearchField => driver.FindElement(By.CssSelector("input[name='q']"));
        IWebElement SearchBtn => driver.FindElements(By.CssSelector("input[name='btnK']"))[1];

        public GoogleSearchHome()
        {
            driver = new ChromeDriver
            {
                Url = "https://www.google.com/"
            };
        }

        public SearchResultPage SearchFor(string searchString)
        {
            SearchField.SendKeys(searchString);
            SearchBtn.Click();
            return new SearchResultPage(driver);
        }

        ~GoogleSearchHome()
        {
            driver.Quit();
        }
    }
}