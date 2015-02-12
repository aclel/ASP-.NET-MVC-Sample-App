using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Cfg;

namespace StoreApplication.Models
{
    public class NHibernateSession
    {
        /** 
         * Opens an NHibernate session which allows communication with the database.
         */
        public static ISession OpenSession()
        {
            var configuration = new Configuration();
            var configurationPath = HttpContext.Current.Server.MapPath(@"~\Models\NHibernate\hibernate.cfg.xml");
            configuration.Configure(configurationPath);
            var productConfigurationFile = HttpContext.Current.Server.MapPath(@"~\Models\NHibernate\Product.hbm.xml");
            configuration.AddFile(productConfigurationFile);
            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}