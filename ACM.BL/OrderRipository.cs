using System;

namespace ACM.BL
{
    public class OrderRipository
    {
        public Order Retrive(int orderId)
        {
            Order order = new Order(orderId);
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 10, 10, 00, 00,
                                                     new TimeSpan(7, 0, 0));

            }
            return order;
        }

        public bool Save(Order order)
        {
            // Code that saves the defined customer
            var success = true;
            if (order.HasChanges)
            {
                if (order.Isvalid)
                {
                    if (order.IsNew)
                    {
                        // Call an Insert Stored Procedure
                    }
                    else
                    {
                        // Call an Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
