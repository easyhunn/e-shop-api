using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MISA.VMHUNG.Core.Interface;
using MISA.VMHUNG.Core.Service;
using MISA.VMHUNG.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.VMHUNG.ESHOP
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
            services.AddCors();
            services.AddControllers().AddJsonOptions(options =>
             {
                 options.JsonSerializerOptions.PropertyNamingPolicy = null;
             }
            );
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IStoreRepository), typeof(StoreRepository));
            services.AddScoped(typeof(IStoreService), typeof(StoreService));
            services.AddScoped(typeof(IProvinceRepository), typeof(ProvinceRepository));
            services.AddScoped(typeof(IProvinceService), typeof(ProvinceService));
            services.AddScoped(typeof(ICountryRepository), typeof(CountryRepository));
            services.AddScoped(typeof(ICountryService), typeof(CountryService));
            services.AddScoped(typeof(IDistrictRepository), typeof(DistrictRepository));
            services.AddScoped(typeof(IDistrictService), typeof(DistrictService));
            services.AddScoped(typeof(IWardRepository), typeof(WardRepository));
            services.AddScoped(typeof(IWardService), typeof(WardService));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MISA.VMHUNG.ESHOP", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MISA.VMHUNG.ESHOP v1"));
            }
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().SetPreflightMaxAge(TimeSpan.FromMinutes(10)));
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
