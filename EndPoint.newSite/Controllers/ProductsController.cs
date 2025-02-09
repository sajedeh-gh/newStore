using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using newStore.Application.Interfaces.FacadPatterns;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.newSite.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductFacad _productFacad;

        public ProductsController(IProductFacad productFacad)
        {
            _productFacad = productFacad;
        }
        public IActionResult Index(string Searchkey, long? CatId = null, int page = 1)
        {
            return View(_productFacad.GetProductForSiteService.Execute(Searchkey, page, CatId).Data);
        }

        public IActionResult Detail(long Id)
        {
            return View(_productFacad.GetProductDetailForSiteService.Execute(Id).Data);
        }
    }
}
