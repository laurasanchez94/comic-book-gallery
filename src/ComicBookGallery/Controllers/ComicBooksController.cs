using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController: Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "the amazing spider man",
                IssueNumber = 700,
                DescriptionHTML = "<p> Final issue!witnedd the final hours of Doctor Octopus life and his one, las act of revenge act of revenge ! EventArgs if spidermans survives...<strong>peter parker/</strong></p>",

                Artists = new Artist[]
                {
                    new Artist(){Name = "Dan Slott", Role="Script"},
                    new Artist(){Name = "Humberto Ramos", Role="Pencils"},
                    new Artist(){Name = "Victor Olazaba", Role="Inks"},
                    new Artist(){Name =" Edgar Delgado", Role="Colors"},
                    new Artist(){Name = "Chris Eliopoulos", Role="Letters"}
                }

            };
         
            return View(comicBook);
        }
    }

}