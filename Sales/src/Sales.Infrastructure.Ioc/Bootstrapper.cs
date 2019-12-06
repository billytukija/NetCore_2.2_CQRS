using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Sales.Infrastructure.Ioc
{
    public static class Bootstrapper
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddMediatR(typeof(QuotationQueryHandler).Assembly);
        }
    }
}
