using System.Collections.Generic;

namespace ACM.BL
{
    public class OrderItem : EntityBase
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public int OrderItemId { get; private set; }
        //public Product Product { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrise { get; set; }
        public int Quantity { get; set; }

        public override bool Validate()
        {
            var isValide = true;

            if (ProductId <= 0) isValide = false;
            if (Quantity <= 0) isValide = false;
            if (PurchasePrise == null) isValide = false;


            return isValide;
        }

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
