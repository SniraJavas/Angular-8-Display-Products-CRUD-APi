using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDataOrbis.Models
{

    public class ProductRootobject
    { 
        public Product[] Property { get; set; }
    }

    public class Product
    {
        [Key]
        public int ProductsID { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescriptionOriginal { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public string ProductStatus { get; set; }
        public string ProductBarcode { get; set; }
        public string Rowchecksum { get; set; }
    }

}
