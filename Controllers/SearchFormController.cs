using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UmbacoTutorial.Models;
using Umbraco.Web.Mvc;

namespace UmbacoTutorial.Controllers
{
    public class SearchFormController : SurfaceController
    {
        // GET: SearchForm
        public ActionResult Submit(Search model)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();


            return RedirectToCurrentUmbracoPage();
        }
    }
}