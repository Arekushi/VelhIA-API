using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using VelhIA_API.IoC.DI;
using VelhIA_API.Data.Context;
using Microsoft.EntityFrameworkCore;
using VelhIA_API.Middlewares.Middlewares;
using Newtonsoft.Json.Serialization;

namespace VelhIA_API.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(o =>
            {
                o.Filters.Add(new ProducesAttribute("application/json"));
            })
            .SetCompatibilityVersion(CompatibilityVersion.Latest)
            .AddNewtonsoftJson(o =>
            {
                o.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                o.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                o.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                JsonConvert.DefaultSettings = () => o.SerializerSettings;
            });

            services.AddDbContext<AppDbContext>(o =>
            {
                string connection = Configuration.GetConnectionString("mySQL");
                // o.UseSqlite(Configuration.GetConnectionString("default"));
                o.UseMySql(connection, ServerVersion.AutoDetect(connection));
            });

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.ConfigureBusinessServices(Configuration);
            services.ConfigureMappings();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "VelhIA API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "VelhIA API v1"));
            }

            app.UseCors("MyPolicy");
            app.UseMiddleware<ExceptionHandlerMiddleware>();

            // app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
