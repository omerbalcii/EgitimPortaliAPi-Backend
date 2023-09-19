using PortalBusinessEngine.Contracts;
using PortalCommon.Dtos;
using PortalCommon.ResultConstant;
using PortalData.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PortalBusinessEngine.İmplemantation
{
    public class ItemBusinessEngine : IItemBusinessEngine
    {
        private readonly IUnitOfWork _uow;
        public ItemBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public Result<List<ItemDto>> GetItems()
        {
            List<ItemDto> items = new List<ItemDto>();
            var data = _uow.items.GetAll().ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    items.Add(new ItemDto()
                    {
                        ItemId = item.ItemId,
                        Name = item.Name,
                        Price = item.Price
                    });
                }
                return new Result<List<ItemDto>>(true, ResultConstant.RecordFound, items);
            }
            return new Result<List<ItemDto>>(false, ResultConstant.RecordNotFound);
        }
    }
}

