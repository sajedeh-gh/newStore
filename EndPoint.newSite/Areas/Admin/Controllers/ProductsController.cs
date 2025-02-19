﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using newStore.Application.Interfaces.FacadPatterns;
using newStore.Application.Services.Products.Commands.AddNewProduct;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Azure.Core;
using newStore.Domain.Entities.Products;
using newStore.Application.Services.Users.Commands.EditProductForAdmin;

namespace EndPoint.newSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {

        private readonly IProductFacad _productFacad;

        public ProductsController(IProductFacad productFacad)
        {
            _productFacad = productFacad;
        }
        public IActionResult Index(int Page = 1, int PageSize = 20)
        {
            return View(_productFacad.GetProductForAdminService.Execute(Page, PageSize).Data);
        }

        public IActionResult Detail(long Id)
        {
               return View(_productFacad.GetProductDetailForAdminService.Execute(Id).Data);
        }
       
        [HttpGet]
        public IActionResult AddNewProduct()
        {
            ViewBag.Categories = new SelectList(_productFacad.GetAllCategoriesService.Execute().Data, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult AddNewProduct(RequestAddNewProductDto request, List<AddNewProduct_Features> Features)
        {
            List<IFormFile> images = new List<IFormFile>();
            for (int i = 0; i < Request.Form.Files.Count; i++)
            {
                var file = Request.Form.Files[i];
                images.Add(file);
            }
            request.Images = images;
            request.Features = Features;
            return Json(_productFacad.AddNewProductService.Execute(request));
        }

        [HttpPost]
        public IActionResult DeleteProductForAdmin(long ProductsId)
        {

            return Json(_productFacad.DeleteProductForAdminService.Execute(ProductsId));

        }

        [HttpPost]
        public IActionResult EditProductForAdmin(string Name ,string Brand , string Description , int Price 
            , int Inventory , long ProductsId, bool Displayed)
        {
            return Json(_productFacad.EditProductForAdminService.Execute(new RequestEditProductForAdminDto
            {
                Brand = Brand,
                Description = Description,
                Name = Name,
                Price = Price,
                ProductsId = ProductsId,
                Inventory = Inventory,
                Displayed = Displayed,
            }));
        }
    }
}
