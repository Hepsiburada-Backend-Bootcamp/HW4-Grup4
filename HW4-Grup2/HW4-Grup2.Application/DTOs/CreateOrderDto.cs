﻿using HW4_Grup2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Grup2.Application.DTOs
{
    public class CreateOrderDto
    {
        //public int Id { get; set; }

        public double TotalPrice { get; set; }

        public string Address { get; set; }

        //public int OrderNumber { get; set; }

        public List<OrderItemDto> OrderItems { get; set; }

        public int UserId { get; set; }
        

        //public virtual ICollection<OrderItem> OrderItems { get; set; }

    }
}
