using NUnit.Framework;
using NUnit.Framework.Internal;

namespace NUnitProject1
{
    public class Tests
    {
        [Test(Description = "The test checks there's a specific string contained in the specified search results item header.")]
        public void Fourth_search_result_contains_given_string()
        {
            const string searchString = "Selenium IDE export to C#";
            const string expectedResults = "Selenium IDE";

            var searchResults = GoogleSearch.SearchFor(searchString);
            var fourthSearchResult = searchResults.GetResultNo(4);

            Assert.IsTrue(fourthSearchResult.HeaderText.Contains(expectedResults),
                $"Actual text was: '{fourthSearchResult.HeaderText}' while we expected it to contain '{expectedResults}'");
        }

        public ISearchEngine GoogleSearch => new GoogleSearchEngine(); // not sure about this approach from abstraction point of view - instantiating exact class within test.
    }
}