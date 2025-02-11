using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EndPoint.newSite.Models;
using newStore.Application.Services.Common.Queries.GetSlider;
using newStore.Application.Interfaces.FacadPatterns;
using newStore.Application.Services.Products.Queries.GetProductForSite;
using EndPoint.newSite.Models;
using newStore.Application.Interfaces.FacadPatterns;
using newStore.Application.Services.Common.Queries.GetSlider;
using newStore.Application.Services.Products.Queries.GetProductForSite;
using newStore.Application.Services.Common.Queries.GetHomePageImages;
using EndPoint.newSite.Models.ViewModels.HomePages;

namespace EndPoint.newSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGetSliderService _getSliderService;
        private readonly IGetHomePageImagesService _homePageImagesService;
        private readonly IProductFacad _productFacad;

        public HomeController(ILogger<HomeController> logger
            , IGetSliderService getSliderService
            , IGetHomePageImagesService homePageImagesService
           , IProductFacad productFacad)
        {
            _logger = logger;
            _getSliderService = getSliderService;
            _homePageImagesService = homePageImagesService;
            _productFacad = productFacad;
        }

        public IActionResult Index()
        {

            HomePageViewModel homePage = new HomePageViewModel()
            {
                Sliders = _getSliderService.Execute().Data,
                PageImages = _homePageImagesService.Execute().Data,
                Camera = _productFacad.GetProductForSiteService.Execute(Ordering.theNewest
                , null, 1, 6, 25).Data.Products,
            };
            return View(homePage);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
