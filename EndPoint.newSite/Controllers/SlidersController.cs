﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using newStore.Application.Services.HomePages.AddNewSlider;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.newSite.Areas.Admin.Controllers
{
   [Area("Admin")]
    public class SlidersController : Controller
    {
        private readonly IAddNewSliderService _addNewSliderService;

        public SlidersController(IAddNewSliderService addNewSliderService)
        {
            _addNewSliderService = addNewSliderService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(IFormFile file , string link)
        {
            _addNewSliderService.Execute(file, link);
            return View();
        }
    }
}
