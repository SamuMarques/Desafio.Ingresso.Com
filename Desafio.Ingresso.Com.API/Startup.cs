using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Ingresso.Com.Domain.Interfaces;
using Desafio.Ingresso.Com.Domain.Interfaces.Services;
using Desafio.Ingresso.Com.Domain.Service;
using Desafio.Ingresso.Com.Infra.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
            ContainerSetup(services);
        }

        private void ContainerSetup(IServiceCollection services)
        {

            //Repository
            services.AddScoped<IFilmeRepository, FilmeRepository>();
            services.AddScoped<ICinemaRepository, CinemaRepository>();
            services.AddScoped<ISalaRepository, SalaRepository>();
            services.AddScoped<ISessaoRepository, SessaoRepository>();

            //Services
            services.AddScoped<IFilmeService, FilmeService>();
            services.AddScoped<ICinemaService, CinemaService>();
            services.AddScoped<ISessaoService, SessaoService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }

    }
}
