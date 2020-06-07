using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApalisInvoice.DAL.Model;
using ApalisInvoice.DAL.Model.Common;
using ApalisInvoice_API.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;


namespace ApalisInvoice_API
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var entityConnections = Configuration.GetSection(nameof(EntityConnections)).Get<EntityConnections>();
            services.AddSingleton(typeof(EntityConnections), entityConnections);
            services.AddMvc(config =>
            {
                //var policy = new AuthorizationPolicyBuilder()
                //.RequireAuthenticatedUser()
                //.Build();
                //config.Filters.Add(new AuthorizeFilter(policy));
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<ApalisInvoiceContext>();
            services.ConfigureDIResolver();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Version = "v1", Title = "Apalise Invoice" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(s => {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "Apalis Invoice");
            });
            //using(var servicescope = app.ApplicationServices.CreateScope())
            //{
            //    var context = servicescope.ServiceProvider.GetService<ApalisInvoiceContext>();
            //}
        }
    }
}
