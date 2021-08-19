﻿using System.ComponentModel.DataAnnotations;

namespace API.CDMRS.Models
{
    public class OrderItemModel
    {
        [Required]
        public OrderModel Order { get; set; }

        [Required]
        public ItemModel Item { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
