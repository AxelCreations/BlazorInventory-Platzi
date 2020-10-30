﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageID { get; set; }
        
        [Required]
        public DateTime LastUpdate { get; set; }
        
        [Required]
        public int PartialQuantity { get; set; }

        public string ProductID { get; set; }
        public ProductEntity Product { get; set; }

        public string WarehouseID { get; set; }
        public WarehouseEntity Warehouse { get; set; }

        public ICollection<InputOutputEntity> InputOutputs { get; set; }
    }
}
