using Microsoft.EntityFrameworkCore;
using newStore.Application.Interfaces.Contexts;
using newStore.Application.Services.Users.Commands.EditProductForAdmin;
using newStore.Common.Dto;
using newStore.Domain.Entities.Users;

namespace newStore.Application.Services.Users.Commands.EditProductForAdmin
{
    public class EditProductForAdminService : IEditProductForAdminService
    {
        private readonly IDataBaseContext _context;

        public EditProductForAdminService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(RequestEditProductForAdminDto request)
        {
            var product = _context.Products.Find(request.ProductsId);
            if (product == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "محصول یافت نشد" 
                };
            }
            product.Brand = request.Brand;
            product.Name = request.Name;
            product.Description = request.Description;
            product.Price = request.Price;
            product.Inventory = request.Inventory;
            product.Displayed = request.Displayed;
            _context.SaveChanges();
            return new ResultDto()
            {
                IsSuccess = true,
                Message = "ویرایش محصول انجام شد"
            };
        }
    }
}