using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Core.Interface;
using Core.Business;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Infraestructure;
using Infraestructure.Interface;
using Infraestructure.Repository;
using System.Data;
using Microsoft.Data.SqlClient;
using Npgsql;

namespace Api
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
            services.AddMvc();
            services.AddOptions();
            services.AddControllers();
            services.AddSwaggerGen(options => {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Weero", Version = "v1" });
            });
            //TODO: Depending on environmentVariable use datacontext
            /* if(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production"){
                services.AddDbContext<MyDatabaseContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("MyDbConnection")));
                
            } */
            var f = Configuration.GetConnectionString("Context");
            //TODO: Configuration is not working if it is loaded from file
            services.AddScoped<IDbConnection>(db => 
                new NpgsqlConnection("Server=localhost;Database=postgres;Uid=manager;Password=holahola19;Pooling=true;"));

            #region BI
            //services.AddScoped<IUserBI, UserBI>();
            services.AddScoped<IDiscoBI, DiscoBI>();
            services.AddScoped<IMatchBI, MatchBI>();
            #endregion

            #region Repository
            //services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IDiscoRespository, DiscoRepository>();
            services.AddScoped<IMatchRepository, MatchRepository>();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Weero");
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
