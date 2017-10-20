﻿using lab17DatabaseDesign.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab17DatabaseDesign.Controllers
{
    public class HomeController : Controller
    {
        private readonly lab17DatabaseDesignContext _context;

        public HomeController(lab17DatabaseDesignContext context)
        {
            _context = context;
        }

        public ViewResult Index()
        {
            return View();
        }
    }
}
