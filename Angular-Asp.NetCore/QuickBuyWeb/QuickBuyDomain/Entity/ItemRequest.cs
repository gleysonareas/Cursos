using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuyDomain.Entity
{
    class ItemRequest
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

    }
}
