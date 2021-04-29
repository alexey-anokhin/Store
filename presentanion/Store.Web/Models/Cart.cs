using System.Collections.Generic;

namespace Store.Web.Models
{
    public class Cart
    {
        internal object Items;

        public int OrderId { get; }

        public int TotalCount { get; set; }

        public decimal TotalPrice { get; set; }

        public Cart(int orderId)
        {
            OrderId = orderId;
            TotalCount = 0;
            TotalPrice = 0m;
        }

        public Cart()
        {
        }
    }
}
