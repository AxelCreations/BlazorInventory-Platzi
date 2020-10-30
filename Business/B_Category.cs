using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Linq;

namespace Business
{
    public class B_Category
    {
        public static CategoryEntity GetCategory(string id)
        {
            using InventoryContext db = new InventoryContext();
            return db.Categories
                .Where(c => c.CategoryID == id)
                .FirstOrDefault();
        }

        public static List<CategoryEntity> CategoryList()
        {
            using InventoryContext db = new InventoryContext();
            return db.Categories.ToList();
        }

        public static void CreateCategory(CategoryEntity oCategory)
        {
            using InventoryContext db = new InventoryContext();
            db.Categories.Add(oCategory);
            db.SaveChanges();
        }

        public static void UpdateCategory(CategoryEntity oCategory)
        {
            using InventoryContext db = new InventoryContext();
            db.Categories.Update(oCategory);
            db.SaveChanges();
        }
    }
}
