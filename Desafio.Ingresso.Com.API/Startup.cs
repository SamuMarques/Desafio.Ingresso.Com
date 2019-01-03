using Desafio.Ingresso.Com.Application.Configuration;
using Desafio.Ingresso.Com.Infra.Core;
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

            ContainerSetup.Container(services);
            AutoMapperConfig.InicializeMapper();

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Desafio Ingresso.com",
                });
            });
        }

        //private void ContainerSetup(IServiceCollection services)
        //{

        //    //Repository
        //    services.AddScoped<IFilmeRepository, FilmeRepository>();
        //    services.AddScoped<ICinemaRepository, CinemaRepository>();
        //    services.AddScoped<ISalaRepository, SalaRepository>();
        //    services.AddScoped<ISessaoRepository, SessaoRepository>();

        //    //Services
        //    services.AddScoped<IFilmeService, FilmeService>();
        //    services.AddScoped<ICinemaService, CinemaService>();
        //    services.AddScoped<ISessaoService, SessaoService>();
        //    services.AddScoped<ISalaService, SalaService>();

        //    //ApplicationServices
        //    services.AddScoped<IFilmeAppService, FilmeAppService>();
        //    services.AddScoped<ICinemaAppService, CinemaAppService>();

        //}

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
