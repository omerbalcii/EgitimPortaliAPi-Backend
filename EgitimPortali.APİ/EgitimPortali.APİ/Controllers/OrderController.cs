using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortalBusinessEngine.Contracts;
using PortalCommon.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace EgitimPortali.APİ.Controllers
{
    [System.Web.Http.Route("api/order")]
    [ApiController]
    //frontend den istek olduğunda veriler buradan çekilecek
    public class OrderController : ControllerBase
    {
        private readonly IOrderBusinessEngine _orderBusinessEngine;
        public OrderController(IOrderBusinessEngine orderBusinessEngine)
        {
            _orderBusinessEngine = orderBusinessEngine;
        }
      // [System.Web.Http.HttpPost()]
       // public IHttpActionResult SaveOrder(OrderDto order)
        //{
         //   var result=_orderBusinessEngine.SaveOrder(order);
            
        //}
    }
}
