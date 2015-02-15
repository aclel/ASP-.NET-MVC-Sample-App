using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHibernate;
using NHibernate.Cfg;
using StoreApplication.Models;
using NHibernate.Linq;

namespace StoreApplication.Controllers
{
    public class MarketController : Controller
    {
        // GET: /Product/
        public ActionResult Index()
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                var markets = session.Query<Market>().ToList();
                return View(markets);
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Market market)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(market);
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
                var market = session.Get<Market>(id);
                return View(market);
            }
        }

        [HttpPost]
        public ActionResult Edit(int id, Market market)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    var marketUpdate = session.Get<Market>(id);
                    marketUpdate.Name = market.Name;
                    marketUpdate.Description = market.Description;

                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(marketUpdate);
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
                var market = session.Get<Market>(id);
                return View(market);
            }
        }

        public ActionResult Delete(int id)
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                var market = session.Get<Market>(id);
                return View(market);
            }
        }

        [HttpPost]
        public ActionResult Delete(int id, Market market)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(market);
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

    }
}
