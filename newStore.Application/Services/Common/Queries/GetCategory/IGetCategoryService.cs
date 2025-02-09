using newStore.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newStore.Application.Services.Common.Queries.GetCategory
{
    public interface IGetCategoryService
    {
        ResultDto<List<CategoryDto>> Execute();
    }
}
