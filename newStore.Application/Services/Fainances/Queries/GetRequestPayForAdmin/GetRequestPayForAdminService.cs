using newStore.Application.Interfaces.Contexts;
using newStore.Common.Dto;
using Microsoft.EntityFrameworkCore;

namespace newStore.Application.Services.Fainances.Queries.GetRequestPayForAdmin
{
    public class GetRequestPayForAdminService : IGetRequestPayForAdminService
    {
        private readonly IDataBaseContext _context;
        public GetRequestPayForAdminService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<List<RequestPayDto>> Execute()
        {
            var requestPay = _context.RequestPays
                .Include(p=>p.User)
                .ToList()
                 .Select(p => new RequestPayDto
                 {
                     Id=p.Id,
                     Amount = p.Amount,
                     Authority = p.Authority,
                     Guid = p.Guid,
                     IsPay = p.IsPay,
                     PayDate = p.PayDate,
                     RefId = p.RefId,
                     UserId = p.UserId,
                     UserName = p.User.FullName
                 }).ToList();

            return new ResultDto<List<RequestPayDto>>()
            {
                Data = requestPay,
                IsSuccess = true,
            };
        }
    }
}
