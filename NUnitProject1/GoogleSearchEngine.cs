namespace NUnitProject1
{
    internal class GoogleSearchEngine : ISearchEngine
    {
        public ISearchResults SearchFor(string searchString)
        {
            var searchHomePage = new GoogleSearchHome();
            var searchResultPage = searchHomePage.SearchFor(searchString);
            return searchResultPage;
        }
    }
}