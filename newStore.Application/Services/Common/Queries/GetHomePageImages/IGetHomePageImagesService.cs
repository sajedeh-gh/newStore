using newStore.Common.Dto;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newStore.Application.Services.Common.Queries.GetHomePageImages
{
    public interface IGetHomePageImagesService
    {
        ResultDto<List<HomePageImagesDto>> Execute();
    }
}
