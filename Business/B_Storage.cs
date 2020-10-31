using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class B_Storage
    {
        public static StorageEntity GetStorage(string id)
        {
            using InventoryContext db = new InventoryContext();
            return db.Storages
                .Where(wh => wh.StorageID == id)
                .FirstOrDefault();
        }

        public static List<StorageEntity> StorageList()
        {
            using InventoryContext db = new InventoryContext();
            return db.Storages.ToList();
        }

        public static List<StorageEntity> StorageProductsByWarehouse(string warehouseId)
        {
            using InventoryContext db = new InventoryContext();
            return db.Storages
                .Include(s => s.Product)
                .Include(s => s.Warehouse)
                .Where(s => s.WarehouseID == warehouseId)
                .ToList();
        }

        public static void CreateStorage(StorageEntity oStorage)
        {
            using InventoryContext db = new InventoryContext();
            db.Storages.Add(oStorage);
            db.SaveChanges();
        }

        public static void UpdateStorage(StorageEntity oStorage)
        {
            using InventoryContext db = new InventoryContext();
            db.Storages.Update(oStorage);
            db.SaveChanges();
        }

        public static bool IsProductInWarehouse(string id)
        {
            using InventoryContext db = new InventoryContext();
            return db.Storages
                .Where(s => s.StorageID == id)
                .Any();
        }
    }
}
