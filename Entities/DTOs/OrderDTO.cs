﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public decimal TotalPrice { get; set; }
        public int TotalQuantity { get; set; }
        public bool IsDelivered { get; set; }
    }
}
