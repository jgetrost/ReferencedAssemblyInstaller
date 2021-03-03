using System;
using System.Collections.Generic;
using System.Text;

namespace Foo.Services
{
    public class FooService
    {
        private readonly FooConfig _fooConfig;

        public FooService(FooConfig fooConfig)
        {
            this._fooConfig = fooConfig;
        }
        public string Print()
        {
            return this._fooConfig.Foo;
        }
    }
}
