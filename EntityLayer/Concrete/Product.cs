﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        public  int ProductID { get; set; }
        public  string ProductName { get; set; }
        public  int ProductPrice { get; set; }
        public  int ProductStock { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
