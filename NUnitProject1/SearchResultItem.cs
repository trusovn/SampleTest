using OpenQA.Selenium;

namespace NUnitProject1
{
    internal class SearchResultItem : ISearchResultsItem
    {
        public string HeaderText => Header.Text;

        private readonly IWebElement resultItem;
        IWebElement Header => resultItem.FindElement(By.TagName("h3"));

        public SearchResultItem(IWebDriver driver, By by)
        {
            resultItem = driver.FindElement(by);
        }
    }
}