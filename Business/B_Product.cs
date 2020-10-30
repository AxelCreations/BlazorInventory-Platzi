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
        public ProductEntity GetProduct(string id)
        {
            using InventoryContext db = new InventoryContext();
            return db.Products
                .Where(p => p.ProductID == id)
                .FirstOrDefault();
        }

        public List<ProductEntity> ProductList()
        {
            using InventoryContext db = new InventoryContext();
            return db.Products.ToList();
        }

        public void CreateProduct(ProductEntity oProduct)
        {
            using InventoryContext db = new InventoryContext();
            db.Products.Add(oProduct);
            db.SaveChanges();
        }

        public void UpdateProduct(ProductEntity oProduct)
        {
            using InventoryContext db = new InventoryContext();
            db.Products.Update(oProduct);
            db.SaveChanges();
        }
    }
}
