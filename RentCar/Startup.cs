﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(RentCar.Startup))]
namespace RentCar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
