﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int? ImageId { get; set; }
        public Image Image { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string BarcodeNumber { get; set; }
        public int UnitOfStock { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
