using newStore.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newStore.Application.Services.Products.Queries.GetAllCategories
{
    public interface IGetAllCategoriesService
    {
        ResultDto<List<AllCategoriesDto>> Execute();
    }



}
