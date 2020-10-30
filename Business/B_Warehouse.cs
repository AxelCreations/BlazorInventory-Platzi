using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Linq;

namespace Business
{
    public class B_Warehouse
    {
        public static WarehouseEntity GetWarehouse(string id)
        {
            using InventoryContext db = new InventoryContext();
            return db.Warehouses
                .Where(wh => wh.WarehouseID == id)
                .FirstOrDefault();
        }

        public static List<WarehouseEntity> WarehouseList()
        {
            using InventoryContext db = new InventoryContext();
            return db.Warehouses.ToList();
        }

        public static void CreateWarehouse(WarehouseEntity oWarehouse)
        {
            using InventoryContext db = new InventoryContext();
            db.Warehouses.Add(oWarehouse);
            db.SaveChanges();
        }

        public static void UpdateWarehouse(WarehouseEntity oWarehouse)
        {
            using InventoryContext db = new InventoryContext();
            db.Warehouses.Update(oWarehouse);
            db.SaveChanges();
        }
    }
}
