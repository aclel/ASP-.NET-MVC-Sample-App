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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(product);
                        transaction.Commit();
                    }
                }
                return RedirectToAction("Index");
            }
            catch (Exception exception)
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                var product = session.Get<Product>(id);
                return View(product);
            }
        }

        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    var productUpdate = session.Get<Product>(id);
                    productUpdate.Name = product.Name;
                    productUpdate.Description = product.Description;
                    productUpdate.Price = product.Price;

                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(productUpdate);
                        transaction.Commit();
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                var product = session.Get<Product>(id);
                return View(product);
            }
        }

        public ActionResult Delete(int id)
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                var product = session.Get<Product>(id);
                return View(product);
            }
        }

        [HttpPost]
        public ActionResult Delete(int id, Product product)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(product);
                        transaction.Commit();
                    }
                }
                return RedirectToAction("Index");
            }
            catch(Exception exception)
            {
                return View();
            }
        }
    }
}
