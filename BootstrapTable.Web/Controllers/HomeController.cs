using BootstrapTable.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapTable.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() { return View(); }
        public ActionResult Basic() { return View(); }
        public ActionResult Paged() { return View(); }
        public ActionResult Menus() { return View(); }
        public ActionResult Links() { return View(); }
        public ActionResult Sorting() { return View(); }
        public ActionResult TableStyles() { return View(); }
        public ActionResult ColumnStyles() { return View(); }
        public ActionResult Toolbar() { return View(); }

        private List<Person> PeopleSource()
        {
            return new List<Person>
            {
                new Person { Id = 1, FirstName = "First1", LastName = "Last1", Email = "1@host.com", Active = true, },
                new Person { Id = 2, FirstName = "First2", LastName = "Last2", Email = "2@host.com", Active = true, },
                new Person { Id = 3, FirstName = "First3", LastName = "Last3", Email = "3@host.com", Active = true, },
                new Person { Id = 4, FirstName = "First4", LastName = "Last4", Email = "4@host.com", Active = true, },
                new Person { Id = 5, FirstName = "First5", LastName = "Last5", Email = "5@host.com", Active = true, },
                new Person { Id = 6, FirstName = "First6", LastName = "Last6", Email = "6@host.com", Active = true, },
                new Person { Id = 7, FirstName = "First7", LastName = "Last7", Email = "7@host.com", Active = true, },
            };
        }

        public JsonResult GetPeopleData()
        {
            System.Threading.Thread.Sleep(1000);
            return Json(PeopleSource(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetPeoplePaged(int offset, int limit, string search, string sort, string order)
        {
            var people = PeopleSource();
            var model = new
            {
                total = people.Count(),
                rows = people.Skip((offset / limit) * limit).Take(limit),
            };
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public ActionResult MenuAction(int id)
        {
            if (Request.IsAjaxRequest())
                return JavaScript("alert('MenuAction id = " + id + "')");
            else
                return View("MenuAction", id);
        }
    }
}