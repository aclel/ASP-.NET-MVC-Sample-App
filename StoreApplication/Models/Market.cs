using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreApplication.Models
{
    public class Market
    {
        private IList<Product> _products = null;

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

        public virtual IList<Product> Products
        {
            get { return _products; }
            set { _products = value; }
        }
    }
}