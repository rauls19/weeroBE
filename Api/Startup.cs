using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data.Common;
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
using Infraestructure.Querybuilder;
using Infraestructure.Repository;
using System.Data;
using Microsoft.Data.SqlClient;
using Npgsql;
using Core.Model;


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
            #region Database and Blobs initialization
            services.Configure<StorageAccount>(Configuration.GetSection("StorageAccount"));
            services.AddScoped<DbConnection>(db => 
                new NpgsqlConnection(Configuration.GetConnectionString("Context")));
            #endregion

            #region  Query Builder
            UserKey userkey = new UserKey();
            DiscoKey discokey = new DiscoKey();
            MatchKey matchkey = new MatchKey();
            Configuration.GetSection("UserKey").Bind(userkey);
            Configuration.GetSection("DiscoKey").Bind(discokey);
            Configuration.GetSection("MatchKey").Bind(matchkey);
            services.AddSingleton<UserKey>(uk =>
               userkey);
            services.AddSingleton<DiscoKey>(dk =>
               discokey);
            services.AddSingleton<MatchKey>(mk =>
               matchkey);
            List<Query> q = new List<Query>();
            Configuration.GetSection("Disco").Bind(q);
            Configuration.GetSection("User").Bind(q);
            Configuration.GetSection("Match").Bind(q);
            services.AddSingleton<Builder>(qb =>
                new Builder(q));
            #endregion

            #region BI
            services.AddScoped<IUserBI, UserBI>();
            services.AddScoped<IDiscoBI, DiscoBI>();
            services.AddScoped<IMatchBI, MatchBI>();
            #endregion

            #region Repository
            services.AddScoped<IUserRepository, UserRepository>();
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
