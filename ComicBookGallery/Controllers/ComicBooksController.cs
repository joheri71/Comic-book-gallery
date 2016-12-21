using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        //Returnerar en view som har en url innehållande ComicBooks och Detail. 
        //Den letar i Viewmappen och sökvägen blir ComicBooks/Detail
        public ActionResult Detail()
        {
            return View();   
        }
    }
}