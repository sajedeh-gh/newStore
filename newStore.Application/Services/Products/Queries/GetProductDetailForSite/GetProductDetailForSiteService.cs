using newStore.Application.Interfaces.Contexts;
using newStore.Common.Dto;
using Microsoft.EntityFrameworkCore;

namespace newStore.Application.Services.Products.Queries.GetProductDetailForSite
{
    public class GetProductDetailForSiteService : IGetProductDetailForSiteService
    {
        private readonly IDataBaseContext _context;
        public GetProductDetailForSiteService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ProductDetailForSiteDto> Execute(long Id)
        {
            var Product = _context.Products
                .Include(p=> p.Category)
                .ThenInclude(p=>p.ParentCategory)
                .Include(p=>p.ProductImages)
                .Include(p=> p.ProductFeatures)
                .Where(p=> p.Id==Id).FirstOrDefault();

            if(Product == null)
            {
                throw new Exception("Product Not Found.....");
            }

            return new ResultDto<ProductDetailForSiteDto>()
            {
                Data = new ProductDetailForSiteDto
                {
                    Brand = Product.Brand,
                    Category = $"{Product.Category.ParentCategory.Name}  - {Product.Category.Name}",
                    Description = Product.Description,
                    Id = Product.Id,
                    Price = Product.Price,
                    Title = Product.Name,
                    Images = Product.ProductImages.Select(p => p.Src).ToList(),
                    Features = Product.ProductFeatures.Select(p => new ProductDetailForSite_FeaturesDto
                    {
                        DisplayName = p.DisplayName,
                        Value = p.Value,
                    }).ToList(),

                },
                IsSuccess = true,
            };

        }
    }




}
