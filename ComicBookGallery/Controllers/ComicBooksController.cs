using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        //Returnerar en view som har en url innehållande ComicBooks och Detail. 
        //Den letar i Viewmappen och sökvägen blir ComicBooks/Detail
        public ActionResult Detail()
        {
            //Instansierar ett objekt av klassen ComicBook och lägger till ett antal Artists i propertyn Artists
            //som är en array av Artists
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The amzing Spider-Man",
                IssueNumber = 7,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus life and his one, last, great act of revenge!" +
                                    "Even if Spider-Man survives <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script"},
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils"},
                    new Artist() { Name = "Victor Olazaba", Role = "Inks"},
                    new Artist() { Name = "Edgar Delgado", Role = "Colors"},
                    new Artist() {Name = "Chris Eliopoulos", Role = "Letters" }
                }
            };

            //ViewBag.SeriesTitle = "The amzing Spider-Man";
            //ViewBag.IssueNumber = 700;
            //ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus life and his one, last, great act of revenge!" +
            //                  "Even if Spider-Man survives <strong>will Peter Parker?</strong></p>";
            //ViewBag.Artists = new string[]
            //{
            //    "Script: Dan Slott",
            //    "Pencils: Humberto Ramos",
            //    "Inks: Victor Olazaba",
            //    "Colors: Edgar Delgado",
            //    "Letters: Chris Eliopoulos"
            //};
        
            
            return View(comicBook);   
        }
    }
}