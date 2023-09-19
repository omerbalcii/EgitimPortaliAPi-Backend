using System;
using System.Collections.Generic;
using System.Text;

namespace PortalCommon.Dtos
{
    public class OrderDto 
    {
        public int OrderId { get; set; }
        public string OrderNo { get; set; }
        public decimal GrandTotal { get; set; }
        public string PaymentMethod { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItemModelDto> OrderItemModelDtos { get; set; }
       
    }
}
