using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAspwork.Model
{
    public class ProductEntity
    {
        private string productid;

        public string Productid
        {
            get { return productid; }
            set { productid = value; }
        }
        private string productname;

        public string Productname
        {
            get { return productname; }
            set { productname = value; }
        }
        private string price;

        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private string factory;

        public string Factory
        {
            get { return factory; }
            set { factory = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }


    }
}