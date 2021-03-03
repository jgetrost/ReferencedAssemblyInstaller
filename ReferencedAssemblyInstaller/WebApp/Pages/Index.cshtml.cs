using Foo.Services;
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

        public IndexModel(ILogger<IndexModel> logger, FooService fooService)
        {
            _logger = logger;
            _fooService = fooService;
        }

        public void OnGet()
        {
            ViewData["Foo"] = _fooService.Print();
        }
    }
}
