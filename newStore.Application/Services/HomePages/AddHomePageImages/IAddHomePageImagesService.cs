using newStore.Common.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newStore.Application.Services.HomePages.AddHomePageImages
{
    public interface IAddHomePageImagesService
    {
        ResultDto Execute(requestAddHomePageImagesDto request);
    }
}
