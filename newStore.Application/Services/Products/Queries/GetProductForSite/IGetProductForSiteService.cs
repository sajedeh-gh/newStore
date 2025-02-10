using newStore.Common.Dto;
using newStore.Application.Services.Products.Queries.GetProductForSite;
using newStore.Common.Dto;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace newStore.Application.Services.Products.Queries.GetProductForSite
{
    public interface IGetProductForSiteService
    {
        ResultDto<ResultProductForSiteDto> Execute(Ordering ordering, string SearchKey, int Page, int pageSize, long? CatId);
    }

    public enum Ordering
    {

        NotOrder = 0,
        
        MostVisited = 1,
        
        Bestselling = 2,
      
        MostPopular = 3,
        
        theNewest = 4,
        
        Cheapest = 5,
        
        theMostExpensive = 6
    }

}
