using ACME.Common;
using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order() : this(0)
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        public int CustomerId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        public string Log() =>
            $"{OrderId}: Date: {this.OrderDate.Value.Date} Status:{this.EntityState.ToString()}";

        public override string ToString() =>
            $"{OrderDate.Value.Date}({OrderId})";


        public override bool Validate()
        {
            var isValide = true;

            if (OrderDate == null) isValide = false;

            return isValide;
        }



        //public Order Retrieve(int orderId)
        //{
        //    return new Order();
        //}

        //public List<Order> Retrieve()
        //{
        //    return new List<Order>();
        //}

        //public bool Save()
        //{
        //    return true;
        //}
    }
}
