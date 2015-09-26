using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamProject_Exam
{
    public class Data
    {
        private string date;
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        private string item;
        public string Item
        {
            get { return item; }
            set { item = value; }
        }
        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}", this.date, this.item, this.price);
        }
    }
}