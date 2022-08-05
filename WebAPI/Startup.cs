using Business.Abstract;
using Business.Abstract.MeetingsService;
using Business.Concrete;
using Business.Concrete.MeetingsManager;
using Core.Utilities.Security.Encyption;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Abstract.IMeetingsDal;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.EfMeetingsDal;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace WebAPI
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI", Version = "v1" });
            });
            

            services.AddSingleton<ICustomerService, CustomerManager>();
            services.AddSingleton<ICustomerDal, EfCustomerDal>();
            services.AddSingleton<IRoutineServiceService, RoutineServiceManager>();
            services.AddSingleton<IRoutineServiceDal, EfRoutineServiceDal>();
            services.AddSingleton<ICustomerService, CustomerManager>();
            services.AddSingleton<ICustomerDal, EfCustomerDal>();
            services.AddSingleton<IScheduledMeetingService, ScheduledMeetingManager>();
            services.AddSingleton<IScheduledMeetingDal, EfScheduledMeetingDal>();


            services.AddCors();

            var tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
            
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = tokenOptions.Issuer,
                        ValidAudience = tokenOptions.Audience,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
                    };
                });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI v1"));
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
