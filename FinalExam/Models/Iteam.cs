﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Models
{
    public class Iteam
    {
        public int Iteamid { get; set; }
        public string Description { get; set; }
        public int UnitsOnHand { get; set; }
        public decimal Cost { get; set; }
        public decimal SellingPrice {  get; set; }

    }
}
