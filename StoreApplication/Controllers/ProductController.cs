using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHibernate;
using NHibernate.Linq;
using StoreApplication.Models;

namespace StoreApplication.Controllers
{
    public class ProductController : Controller
    {

        // GET: /Product/
        public ActionResult Index()
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                var products = session.Query<Product>().ToList();
                return View(products);
            }
        }
    }
}
