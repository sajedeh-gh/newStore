using newStore.Common.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace newStore.Application.Services.Products.Queries.GetCategories
{
    public interface IGetCategoriesService
    {
        ResultDto<List<CategoriesDto>> Execute(long? ParentId);
    }
}



