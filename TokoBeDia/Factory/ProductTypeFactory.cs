using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;

namespace TokoBeDia.Factory
{
    public class ProductTypeFactory
    {
        public static MsProductType initProduct(int ID, string ProductType, string Description)
        {
            MsProductType Product = new MsProductType()
            {
                ID = ID,
                Name = ProductType,
                Description = Description
            };
            return Product;
        }
    }
}