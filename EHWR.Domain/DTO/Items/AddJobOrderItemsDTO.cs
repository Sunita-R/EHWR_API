﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DTO.Items
{
    public class AddJobOrderItemsDTO
    {
            public int JobOrderId { get; set; }
            public int ItemType { get; set; }
            public int ItemId { get; set; }
            public string JobItemDescription { get; set; }
            public Decimal UnitPrice { get; set; }
            public int Quantity { get; set; }
            public string CreatedBy { get; set; }
        
    }
}
