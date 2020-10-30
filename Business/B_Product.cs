using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Linq;

namespace Business
{
    public class B_Product
    {
        public static ProductEntity GetProduct(string id)
        {
            using InventoryContext db = new InventoryContext();
            return db.Products
                .Where(p => p.ProductID == id)
                .FirstOrDefault();
        }

        public static List<ProductEntity> ProductList()
        {
            using InventoryContext db = new InventoryContext();
            return db.Products.ToList();
        }

        public static void CreateProduct(ProductEntity oProduct)
        {
            using InventoryContext db = new InventoryContext();
            db.Products.Add(oProduct);
            db.SaveChanges();
        }

        public static void UpdateProduct(ProductEntity oProduct)
        {
            using InventoryContext db = new InventoryContext();
            db.Products.Update(oProduct);
            db.SaveChanges();
        }
    }
}
