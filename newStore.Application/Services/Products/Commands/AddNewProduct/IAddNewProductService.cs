using newStore.Common.Dto;

namespace newStore.Application.Services.Products.Commands.AddNewProduct
{
    public interface IAddNewProductService
    {
        ResultDto Execute(RequestAddNewProductDto request);
    }
}
