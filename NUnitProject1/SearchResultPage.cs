using OpenQA.Selenium;

namespace NUnitProject1
{
    public class SearchResultPage : ISearchResults
    {
        private readonly IWebDriver driver;

        public SearchResultPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public ISearchResultsItem GetResultNo(int resultItemPosition)
        {
            return new SearchResultItem(driver, By.XPath($"//div[@id='rso']/div[@class='g'][{resultItemPosition}]"));
        }
    }
}