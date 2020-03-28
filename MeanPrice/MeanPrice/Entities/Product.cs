﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MeanPrice.Entities
{
    class Product
    {
        public String Name { get; set; }

        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
