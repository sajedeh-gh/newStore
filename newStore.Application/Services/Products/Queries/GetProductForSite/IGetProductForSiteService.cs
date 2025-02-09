using newStore.Common.Dto;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newStore.Application.Services.Products.Queries.GetProductForSite
{
    public interface IGetProductForSiteService
    {
        ResultDto<ResultProductForSiteDto> Execute(string SearchKey , int Page, long? CatId);
    }

}
