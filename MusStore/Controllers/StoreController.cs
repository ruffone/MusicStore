using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusStore.Models;

namespace MusStore.Controllers
{
    public class StoreController : Controller
    {
        StoreContext db = new StoreContext();
        // GET: Store
        public ActionResult Index()
        {
            var albums = GetTopSellingAlbums(4);
            var goods = db.Genres.ToList();
            return View(goods);
        }
        public ActionResult Browse(string genre)
        {
            var genreModel = db.Genres.Include("Albums")
                .Single(g => g.Name == genre);
            return View(genreModel);
        }
        public ActionResult Details(long id = 1)
        {
            var album = db.Albums.Find(id);

            return View(album);
        }
        private List<Album> GetTopSellingAlbums(int count)
        {
            // Group the order details by album and return
            // the albums with the highest count
            return db.Albums
                .OrderByDescending(a => a.OrdDetails.Count())
                .Take(count)
                .ToList();
        }


        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = db.Genres.ToList();
            return PartialView(genres);
        }
    }
}