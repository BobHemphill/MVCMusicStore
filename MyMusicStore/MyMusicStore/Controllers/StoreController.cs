using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMusicStore.Models;

namespace MyMusicStore.Controllers {
	public class StoreController : Controller {
		public string Index() {
			return "Hello from Store.Index()";
		}

		public ActionResult Browse(string genre) {
			var genreModel = new Genre {Name = "Genre " + genre};
			return View(genreModel);
		}

		public ActionResult Details(int id) {
			var albumModel = new Album {Title = "Album " + id};
			return View(albumModel);
		}
	}
}