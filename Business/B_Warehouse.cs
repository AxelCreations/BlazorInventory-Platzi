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
        public WarehouseEntity GetWarehouse(string id)
        {
            using InventoryContext db = new InventoryContext();
            return db.Warehouses
                .Where(wh => wh.WarehouseID == id)
                .FirstOrDefault();
        }

        public List<WarehouseEntity> WarehouseList()
        {
            using InventoryContext db = new InventoryContext();
            return db.Warehouses.ToList();
        }

        public void CreateWarehouse(WarehouseEntity oWarehouse)
        {
            using InventoryContext db = new InventoryContext();
            db.Warehouses.Add(oWarehouse);
            db.SaveChanges();
        }

        public void UpdateWarehouse(WarehouseEntity oWarehouse)
        {
            using InventoryContext db = new InventoryContext();
            db.Warehouses.Update(oWarehouse);
            db.SaveChanges();
        }
    }
}
