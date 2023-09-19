using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortalBusinessEngine.Contracts;
using PortalCommon.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgitimPortali.APİ.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerBusinessEngine _customerBusiness;
        public CustomerController(ICustomerBusinessEngine customerBusiness)
        {
            _customerBusiness = customerBusiness;

        }

        [HttpGet("GetCustomerList")]
        public List<CustomerDto> GetCustomerList()
        {
            return _customerBusiness.GetCustomer().Data;
        }
    }
}

