using PortalBusinessEngine.Contracts;
using PortalCommon.Dtos;
using PortalCommon.ResultConstant;
using PortalData.DataContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalBusinessEngine.İmplemantation
{
    public class OrderBusinessEngine : IOrderBusinessEngine
    {
        private readonly IUnitOfWork _uow;
        public OrderBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public Result<OrderDto> SaveOrder(OrderDto order)
        {
            throw new NotImplementedException();
        }
    }
}
