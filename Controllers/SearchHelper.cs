using Umbraco.Web;

namespace UmbacoTutorial.Controllers
{
    internal class SearchHelper
    {
        private UmbracoHelper umbracoHelper;

        public SearchHelper(UmbracoHelper umbracoHelper)
        {
            this.umbracoHelper = umbracoHelper;
        }
    }
}