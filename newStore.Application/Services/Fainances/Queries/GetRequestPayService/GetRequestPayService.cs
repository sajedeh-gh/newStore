using newStore.Application.Interfaces.Contexts;
using newStore.Common.Dto;

namespace newStore.Application.Services.Fainances.Queries.GetRequestPayService
{
    public class GetRequestPayService : IGetRequestPayService
    {
        private readonly IDataBaseContext _context;
        public GetRequestPayService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<RequestPayDto> Execute(Guid guid)
        {
            var requestPay = _context.RequestPays.Where(p => p.Guid == guid).FirstOrDefault();

            if (requestPay != null)
            {
                return new ResultDto<RequestPayDto>()
                {
                    Data = new RequestPayDto()
                    {
                        Amount = requestPay.Amount,
                        Id=requestPay.Id,
                    }
                };
            }
            else
            {
                throw new Exception("request pay not found");
            }
        }
    }
}
