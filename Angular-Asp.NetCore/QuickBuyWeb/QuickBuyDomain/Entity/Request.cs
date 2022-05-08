using QuickBuyDomain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuyDomain.Entity
{
    class Request
    {
        public int Id { get; set; }
        public DateTime DateRequest { get; set; }
        public int UserId { get; set; }
        public DateTime DeliveryForecastDate { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int AddressNumber { get; set; }
        public int PaymentId { get; set; }

        public Payment Payment { get; set; }
        public ICollection<ItemRequest> ItensRequest { get; set; }
    }
}
