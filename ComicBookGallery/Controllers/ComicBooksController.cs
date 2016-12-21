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
            ViewBag.SeriesTitle = "The amzing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "Final issue! Witness the final hours of Doctor Octopus life and his one, last, great act of revenge!" +
                              "Even if Spider-Man survives <strong>will Peter Parker?</strong>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };
        
            return View();   
        }
    }
}