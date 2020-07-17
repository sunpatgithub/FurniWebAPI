using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Furni.WebAPI.Common;
using Microsoft.Owin;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Furni.Domain.Entities;
using Microsoft.EntityFrameworkCore;



[assembly: OwinStartup(typeof(Furni.WebAPI.Startup))]
namespace Furni.WebAPI
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


            IConfigurationRoot objConfig = new ConfigurationBuilder()
                  .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                  .AddJsonFile("appsettings.json")
                  .Build();

            #region Connection
            

            services.AddDbContextPool<furniContext>((serviceProvider, optionsBuilder) =>
            {
                //optionsBuilder.UseMySQL(objConfig.GetConnectionString(strDbType));
                //optionsBuilder.UseSqlServer(Configuration["ConnectionStrings"]);
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                optionsBuilder.UseApplicationServiceProvider(serviceProvider);
                optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
            #endregion Connection

            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            #region Jwt Auth
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
           .AddJwtBearer(options =>
           {
               options.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateIssuer = true,
                   ValidateAudience = true,
                   ValidateLifetime = true,
                   ValidateIssuerSigningKey = true,
                   ValidIssuer = Configuration["Jwt:Issuer"],
                   ValidAudience = Configuration["Jwt:Issuer"],
                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
               };
           });
            //  services.AddMvc();

            #endregion Jwt Auth

            #region Logger
            services.AddScoped<ActionFilter.Log>();
            //services.AddMvc(options =>
            //{
            //    options.Filters.Add(typeof(Log));
            //});
            #endregion Logger


            //Register the Swagger generator, defining 1 or more Swagger documents
            //services.AddSwaggerGen(c =>
            //{
            //    c.OperationFilter<AddHeaders>();
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "HR_UK API", Version = "v1" });

            //    //c.DescribeAllEnumsAsStrings();
            //});

            // Inject an implementation of ISwaggerProvider with defaulted settings applied
            // services.AddSwaggerGen();

            #region Swagger

            services.AddSwaggerGen(c =>
            {
                c.OperationFilter<AddHeaders>();
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger Furni", Version = "v1" });
            });

            #endregion Swagger



        }
        


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            ////this is very important line cross orgin source(CORS)it is used to enable cross-site HTTP requests  
            ////For security reasons, browsers restrict cross-origin HTTP requests  
            //app.UseCors(CorsOptions.AllowAll);            
           

            #region Swagger
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyAPI V1");
            });
            // Register the Swagger generator and the Swagger UI middlewares
            //app.UseOpenApi();
            //app.UseSwaggerUi3();
            #endregion Swagger

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

                //app.UseMvc();

        }


    }

    
}
