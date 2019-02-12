using System;
using System.Collections.Generic;
using System.Text;
using Boolood.Framework.Core;
using Boolood.Framework.Core.Query;
using Boolood.Framework.Core.Repository;
using Boolood.Framework.Core.Services;
using Boolood.Framework.DI;
using Boolood.Framework.Repository;
using Boolood.Infrastructure;
using Boolood.Persistence.DbContext;
using Boolood.Read;
using Boolood.Services.Initial;
using Common.ApplicationIdentity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace Boolood.Configuration
{
    public class Registrar
    {

        public void Register(IServiceCollection services)
        {
            services.AddScoped<AppDbContext>();
            services.AddScoped<AppIdentityDbContext>();
            services.AddScoped<IDiContainer>(sp => new DiContainer(sp));
            services.AddScoped<ServiceLocator>();

            services.AddScoped<IIdentityRepository, IdentityRepository>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<ILanguageRepository, LanguageRepository>();

            services.AddScoped<IArticleQuery, ArticleQuery>();
            services.AddScoped<IArticleService, Services.ArticleContext.Article>();

            services.AddScoped<ILanguageQuery, LanguageQuery>();
            services.AddScoped<ILanguageBasedService, Services.CultureContext.Language>();

            services.AddScoped<InitializerService>();
        }
    }
}
