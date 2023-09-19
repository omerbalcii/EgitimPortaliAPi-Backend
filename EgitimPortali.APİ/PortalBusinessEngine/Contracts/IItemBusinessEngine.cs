using PortalCommon.Dtos;
using PortalCommon.ResultConstant;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalBusinessEngine.Contracts
{
    public interface IItemBusinessEngine
    {
        Result<List<ItemDto>> GetItems();
    }
}
