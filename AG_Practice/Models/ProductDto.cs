using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AG_Practice.Models
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public string Size { get; set; }
        public decimal? Weight { get; set; }
        public int? ProductCategoryId { get; set; }
        public int? ProductModelId { get; set; }
        public DateTime SellStartDate { get; set; }
        public DateTime? SellEndDate { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public byte[] ThumbNailPhoto { get; set; }
        public string ThumbnailPhotoFileName { get; set; }
        public Guid RowGuid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public ProductModel ProductModel { get; set; }
        public ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}