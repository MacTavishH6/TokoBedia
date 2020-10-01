using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;

namespace TokoBeDia.Factory
{
    public class ProductFactory
    {
        public static MsProduct initProduct(string Name, int Stock, int Price, int ProductType)
        {
            MsProduct product = new MsProduct()
            {
                Name = Name,
                Stock = Stock,
                Price = Price,
                ProductTypeID = ProductType
            };
            return product;
        }
    }
}