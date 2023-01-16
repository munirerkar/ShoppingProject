using Entities.Concrete;
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

        public static string CategoryAdded = "Kategori Eklendi";
        public static string CategoryUpdated = "Kategori Güncellendi";
        public static string CategoryDeleted = "Kategori Silindi";

        public static string CategoryNonDeletedListed = "Kategoriler Listelendi";
        public static string CategoryDeletedListed = "Silinmiş Kategoriler Listelendi";

        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marka Güncellendi";
    }
}
