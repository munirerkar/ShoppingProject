using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string ProductAdded = "Ürün Eklendi"; 
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string ProductDeleted = "Ürün Tamamen Silindi";

        public static string ProductUndoDeleted = "Ürün Geri Getirildi";
        public static string ProductSafeDeleted = "Ürün Silindi";

        public static string ProductNonDeletedListed = "Ürünler Listelendi";
        public static string ProductDeletedListed = "Ürünler Listelendi";
        public static string ProductPriceListed = "Belirlediğiniz Fiyattaki Ürünler Listelendi";
    }
}
