using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcmeIncWeb.Models
{
    public class SimpleReportViewModel
    {
        public string DimensionOne { get; set; }
        public int Quantity { get; set; }

        public SimpleReportViewModel(string dimension, int qty)
        {
            this.DimensionOne = dimension;
            this.Quantity = qty;
        }

    }
}
