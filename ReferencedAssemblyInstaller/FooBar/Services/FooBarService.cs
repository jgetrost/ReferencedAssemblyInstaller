using Bar.Services;
using Core;
using Foo.Services;
using System;
using System.Linq;

namespace FooBar.Services
{


    public class FooBarService
    {
        private readonly FooService _fooService;
        private readonly BarService _barService;
        private readonly FooBarConfiguration _fooBarConfig;

        public FooBarService(FooService fooService, BarService barService, FooBarConfiguration fooBarConfig)
        {
            this._fooService = fooService;
            this._barService = barService;
            this._fooBarConfig = fooBarConfig;
        }

        public string Print()
        {
            return String.Concat(Enumerable.Repeat($"{this._fooService.Print()}{this._barService.Print()}", this._fooBarConfig.FooBarCount));
        }
    }
}
