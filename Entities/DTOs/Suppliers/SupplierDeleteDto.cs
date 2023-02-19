using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Suppliers
{
    public class SupplierDeleteDto : IDto
    {
        public int SupplierId { get; set; }
    }
}
