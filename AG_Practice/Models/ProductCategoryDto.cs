using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AG_Practice.Models
{
    public class ProductCategoryDto
    {
        public int ProductCategoryId { get; set; }

        public int? ParentProductCategoryId { get; set; }

        [Display(Name = "Category")]
        public string Name { get; set; }

        public Guid RowGuid { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}