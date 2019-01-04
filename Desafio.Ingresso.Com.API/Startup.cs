using Desafio.Ingresso.Com.Application.Configuration;
using Desafio.Ingresso.Com.Infra.Core;
using Desafio.Ingresso.Com.Infra.Data.Contexto;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Desafio.Ingresso.Com.API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var dbConnection = Configuration.GetConnectionString("");

            ContainerSetup.Container(services);
            AutoMapperConfig.InicializeMapper();
            Configuration.GetValue<string>("");
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Desafio Ingresso.com",
                });
            });

            services.AddMongo(Configuration.GetConnectionString("DefaultConnection"), 
                Configuration.GetValue<string>("MySettings:MyDbName"));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "Desafio Ingresso.com");
            });
        }

    }
}
