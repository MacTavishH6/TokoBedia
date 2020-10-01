using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Factory;
using TokoBeDia.Model;

namespace TokoBeDia.Repository
{
    public class ProductRepository
    {
        public static TokoBeDiaEntities db = new TokoBeDiaEntities();

        public static List<MsProduct> GetAllProduct()
        {
            return (from x
                    in db.MsProducts
                    select x).ToList();
        }

        public static List<MsProduct> GetFiveProduct()
        {
            return (from x
                    in db.MsProducts
                    select x).Take(5).ToList();
        }

        public static List<MsProduct> GetOneProduct(int ID)
        {
            return  (from x
                    in db.MsProducts
                    where x.ID == ID
                    select x).ToList();
        }

        public static List<MsProductType> GetProductName(int ID)
        {
            return (from x
                    in db.MsProductTypes
                    where x.ID == ID
                    select x).ToList();
        }
        public static void DeleteProduct(int ID)
        {
            db.MsProducts.Remove(GetOneProduct(ID).ElementAt(0));
            db.SaveChanges();
        }
        public static void DeleteProductType(int ID)
        {
            db.MsProductTypes.Remove(GetOneProductType(ID).ElementAt(0));
            db.SaveChanges();
        }
        public static void InsertProduct(string Name, int Stock, int Price, int ProductType)
        {
            db.MsProducts.Add(ProductFactory.initProduct(Name, Stock, Price, ProductType));
            db.SaveChanges();
        }
        public static void InsertProductType(string ProductType, string Description)
        {
            int max = db.MsProductTypes.Max(x => x.ID);
            db.MsProductTypes.Add(ProductTypeFactory.initProduct(++max, ProductType, Description));
            db.SaveChanges();
        }
        public static List<MsProductType> GetProductType()
        {
            return (from x
                    in db.MsProductTypes
                    select x).ToList();
        }
        public static List<MsProductType> GetOneProductType(int ID)
        {
            return (from x
                    in db.MsProductTypes
                    where x.ID == ID
                    select x).ToList();
        }
        public static void UpdateProduct(int ID, string Name, int Stock, int Type, int Price)
        {
            MsProduct product = db.MsProducts.Single(x => x.ID == ID);
            product.Name = Name;
            product.Stock = Stock;
            product.ProductTypeID = Type;
            product.Price = Price;
            db.SaveChanges();
        }
        public static void UpdateProductType(int ID, string ProductType, string Description)
        {
            MsProductType Product = db.MsProductTypes.Single(x => x.ID == ID);
            Product.Name = ProductType;
            Product.Description = Description;
            db.SaveChanges();
        }
    }
}