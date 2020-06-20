using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Server.Database;
using Server.Database.Connection;
using Server.Database.Init;
using Server.Database.Tables;

namespace Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddScoped<DbConnection>();
            services.AddScoped<ServerConnection>();
            
            services.AddScoped<IDbInitialiser, DbInitialiser>();
            services.AddScoped<IDbVerifier, DbVerifier>();
            services.AddScoped<IDbCreator, DbCreator>();

            services.AddScoped<ITableCreator, TableCreator>();
            services.AddScoped<IIdentifierTypeCodingTableCreator, IdentifierTypeCodingTableCreator>();
            services.AddScoped<IIdentifierTypeTableCreator, IdentifierTypeTableCreator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}