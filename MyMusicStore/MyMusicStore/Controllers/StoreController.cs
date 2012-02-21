using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMusicStore.Controllers {
	public class StoreController : Controller {
		public string Index() {
			return "Hello from Store.Index()";
		}

		public string Browse(string genre) {
			return HttpUtility.HtmlEncode(string.Format("Store.Browse, Genre: {0}", genre));
		}

		public string Details(int id) {
			return HttpUtility.HtmlEncode(string.Format("Store.Details, Id: {0}", id));
		}
	}
}