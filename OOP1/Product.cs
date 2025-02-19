﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //CRUD - Create - Read - Update - Delete
    }
}
