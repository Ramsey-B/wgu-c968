﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace InventoryManagement.Models
{
    public abstract class Part
    {
        #region public properties
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        #endregion
    }
}