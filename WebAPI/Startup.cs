


using Core.Utilities.Security.Encyption;
using Core.Utilities.Security.Jwt;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

using System.Collections.Specialized;

namespace WebAPI
{
    public class Startup
    {
        //IScheduler _quartzScheduler;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
           // _quartzScheduler = ConfigureQuartz();
        }
        //public IScheduler ConfigureQuartz()
        //{
        //    NameValueCollection props = new NameValueCollection
        //    {
        //        {"quartz.serializer.type","binary" },
        //    };
        //    StdSchedulerFactory factory = new StdSchedulerFactory(props);
        //    var scheduler = factory.GetScheduler().Result;
        //    scheduler.Start().Wait();
        //    return scheduler;
        //}


        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public async void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI", Version = "v1" });
            });

           // services.AddSingleton(provider => _quartzScheduler);
    


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
            //services.AddSingleton<IJobFactory, MyJobFactory > ();
            //services.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();
            //services.AddSingleton<NotificationJob>();
            //services.AddHostedService<MyScheduler>();

            //var sched = await SchedulerBuilder.Create()
              
            //.UseDedicatedThreadPool(x => x.MaxConcurrency = 5)
            //.UsePersistentStore(x =>
            //{
            //    x.UseProperties = true;
            //    x.UseClustering();
            //    x.UseJsonSerializer();
            //})
            // .UseXmlSchedulingConfiguration(x =>
            // {
            //     x.Files = new[] { "~/quartz_jobs.xml" };
            //     x.FailOnFileNotFound = true;
            //     x.FailOnSchedulingError = true;
            // })
            // .BuildScheduler();
            //await _quartzScheduler.Start();
           
        }
       
        //private void OnShutdown()
        //{
        //    if (!_quartzScheduler.IsShutdown) _quartzScheduler.Shutdown();
        //}

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
