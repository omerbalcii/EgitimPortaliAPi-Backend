using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PortalCommon.Dtos
{
   public class ItemDto
    {
        
        public int ItemId { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
    }
}
