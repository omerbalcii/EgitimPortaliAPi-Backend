﻿using PortalCommon.Dtos;
using PortalCommon.ResultConstant;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalBusinessEngine.Contracts
{
   public interface ICustomerBusinessEngine
    {
        Result<List<CustomerDto>> GetCustomer();
    }
}
