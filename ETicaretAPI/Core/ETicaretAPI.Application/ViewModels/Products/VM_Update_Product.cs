﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.ViewModels.Products
{
    public class VM_Update_Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stok { get; set; }
        public float Price { get; set; }
    }
}
