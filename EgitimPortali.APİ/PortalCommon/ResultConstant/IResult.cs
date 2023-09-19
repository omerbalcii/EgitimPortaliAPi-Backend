using System;
using System.Collections.Generic;
using System.Text;

namespace PortalCommon.ResultConstant
{
   public interface IResult
    {
        bool IsSucces { get; set; }
         string Message { get; set; }
    }
}
