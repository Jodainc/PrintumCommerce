﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrintumCommerce.Startup))]
namespace PrintumCommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
