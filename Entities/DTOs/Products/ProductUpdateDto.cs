﻿using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Products
{
    public class ProductUpdateDto : IDto
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int SupplierId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string BarcodeNumber { get; set; }
        public int UnitOfStock { get; set; }
        public decimal UnitPrice { get; set; }
        public List<IFormFile> Photo { get; set; }
    }
}
