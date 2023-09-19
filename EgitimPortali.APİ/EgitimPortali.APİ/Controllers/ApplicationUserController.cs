using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PortalBusinessEngine.Contracts;
using PortalCommon.Dtos;
using PortalData.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgitimPortali.APİ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly IApplicationUserBusinessEngine _applicationUserEngine;

        public ApplicationUserController(IApplicationUserBusinessEngine applicationUserEngine)
        {
            _applicationUserEngine = applicationUserEngine;
        }

        [HttpGet("Index")]
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpPost]
       [Route("Register")]
       //WWW.apiproje.com/api/ApplicationUser
        public async Task<object> PostApplicationUser(ApplicationUserDto model)
        {
            var data = _applicationUserEngine.CreateApplicationUser(model);
            var result = data.Result.Data;
            return Ok(result);
        }
            }
}
