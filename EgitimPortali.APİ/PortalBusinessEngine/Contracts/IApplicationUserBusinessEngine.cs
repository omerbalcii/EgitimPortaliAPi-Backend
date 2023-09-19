using PortalCommon.Dtos;
using PortalCommon.ResultConstant;
using PortalData.DbModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PortalBusinessEngine.Contracts
{
   public interface IApplicationUserBusinessEngine
    {
        Task<Result<object>> CreateApplicationUser(ApplicationUserDto model);
    }
}
