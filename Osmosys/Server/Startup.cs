using DataAccess.Connections;
using DataAccess.Implementation.Connections;
using DataAccess.Implementation.Init;
using DataAccess.Implementation.MaritalStatuses;
using DataAccess.Init;
using DataAccess.MaritalStatuses;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Npgsql;

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
            ConfigureDbConnections(services);
            ConfigureDbSetupServices(services);
            ConfigureMaritalStatusStorage(services);
        }

        private static void ConfigureDbConnections(IServiceCollection services)
        {
            /*
             * Connection implements both interfaces.
             * This binding allows re-use of object in same injection scope for both interfaces.
             */
            services.AddScoped<IServerConnection<NpgsqlConnection>, ServerConnection>();
            services.AddScoped<DatabaseConnection>();
            services.AddScoped<IDbConnection<NpgsqlConnection>>(x => x.GetService<DatabaseConnection>());
            services.AddScoped<ITransaction>(x => x.GetService<DatabaseConnection>());
        }
        
        private static void ConfigureDbSetupServices(IServiceCollection services)
        {
            services.AddScoped<IDbInitialiser, DbInitialiser>();
            services.AddScoped<IDbCreator, DbCreator>();
            services.AddScoped<IDbVerifier, DbVerifier>();
            services.AddScoped<ITableInitialiser, TableInitialiser>();
        }

        private static void ConfigureMaritalStatusStorage(IServiceCollection services)
        {
            services.AddScoped<IMaritalStatusStorage, MaritalStatusStorage>();
            services.AddScoped<IMaritalStatusTableCreator, MaritalStatusTableCreator>();
            services.AddScoped<IMaritalStatusCodingTableCreator, MaritalStatusCodingTableCreator>();
            services.AddScoped<IMaritalStatusRecordWriter, MaritalStatusRecordWriter>();
            services.AddScoped<IMaritalStatusCodingRecordWriter, MaritalStatusCodingRecordWriter>();
            services.AddScoped<IMaritalStatusRecordReader, MaritalStatusRecordReader>();
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