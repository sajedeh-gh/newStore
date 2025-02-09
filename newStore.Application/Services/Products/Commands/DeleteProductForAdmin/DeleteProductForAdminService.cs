using newStore.Application.Interfaces.Contexts;
using newStore.Common.Dto;

namespace newStore.Application.Services.Products.Commands.DeleteProductForAdmin
{
    public class DeleteProductForAdminService : IDeleteProductForAdminService
    {
        private readonly IDataBaseContext _context;

        public DeleteProductForAdminService (IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(long ProductsId)
        {
            var product = _context.Products.Find(ProductsId);
            if (product == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "محصول یافت نشد"
                };
            }
            product.RemoveTime = DateTime.Now;
            product.IsRemoved = true;
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "محصول با موفقیت حذف شد"

            };
        }
    }
}
