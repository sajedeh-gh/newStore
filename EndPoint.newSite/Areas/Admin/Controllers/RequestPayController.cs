using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using newStore.Application.Services.Fainances.Queries.GetRequestPayForAdmin;
using Microsoft.AspNetCore.Mvc;
using newStore.Application.Services.Fainances.Queries.GetRequestPayForAdmin;

namespace EndPoint.newSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RequestPayController : Controller
    {
        private readonly IGetRequestPayForAdminService _getRequestPayForAdminService;
        public RequestPayController(IGetRequestPayForAdminService getRequestPayForAdminService)
        {
            _getRequestPayForAdminService = getRequestPayForAdminService;
        }
        public IActionResult Index()
        {
            return View(_getRequestPayForAdminService.Execute().Data);
        }
    }
}
