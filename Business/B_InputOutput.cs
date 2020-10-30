using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Linq;

namespace Business
{
    public class B_InputOutput
    {
        public InputOutputEntity GetInOut(string id)
        {
            using InventoryContext db = new InventoryContext();
            return db.InOuts
                .Where(io => io.InOutID == id)
                .FirstOrDefault();
        }

        public List<InputOutputEntity> InOutList()
        {
            using InventoryContext db = new InventoryContext();
            return db.InOuts.ToList();
        }

        public void CreateInOut(InputOutputEntity oInOuts)
        {
            using InventoryContext db = new InventoryContext();
            db.InOuts.Add(oInOuts);
            db.SaveChanges();
        }

        public void UpdateInOut(InputOutputEntity oInOuts)
        {
            using InventoryContext db = new InventoryContext();
            db.InOuts.Update(oInOuts);
            db.SaveChanges();
        }
    }
}
