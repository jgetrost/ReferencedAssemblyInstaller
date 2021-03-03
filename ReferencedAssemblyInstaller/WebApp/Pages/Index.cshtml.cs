using Bar.Services;
using Foo.Services;
using FooBar.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly FooService _fooService;
        private readonly BarService _barService;
        private readonly FooBarService _fooBarService;

        public IndexModel(ILogger<IndexModel> logger, FooService fooService, BarService barService, FooBarService fooBarService)
        {
            this._logger = logger;
            this._fooService = fooService;
            this._barService = barService;
            this._fooBarService = fooBarService;

        }

        public void OnGet()
        {
            ViewData["Foo"] = _fooService.Print();
            ViewData["Bar"] = _barService.Print();
            ViewData["FooBar"] = _fooBarService.Print();
        }
    }
}
