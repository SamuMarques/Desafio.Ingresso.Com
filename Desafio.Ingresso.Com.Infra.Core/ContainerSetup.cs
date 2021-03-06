﻿using Desafio.Ingresso.Com.Application.ApplicationServices;
using Desafio.Ingresso.Com.Application.Interfaces;
using Desafio.Ingresso.Com.Domain.Interfaces;
using Desafio.Ingresso.Com.Domain.Interfaces.Services;
using Desafio.Ingresso.Com.Domain.Service;
using Desafio.Ingresso.Com.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Desafio.Ingresso.Com.Infra.Core
{
    public static class ContainerSetup
    {
        public static void Container(IServiceCollection services)
        {
            //Repository
            services.AddScoped<IFilmeRepository, FilmeRepository>();
            services.AddScoped<ICinemaRepository, CinemaRepository>();
            services.AddScoped<ISalaRepository, SalaRepository>();
            services.AddScoped<ISessaoRepository, SessaoRepository>();
            services.AddScoped<ICidadeRepository, CidadeRepository>();

            //Services
            services.AddScoped<IFilmeService, FilmeService>();
            services.AddScoped<ICinemaService, CinemaService>();
            services.AddScoped<ISessaoService, SessaoService>();
            services.AddScoped<ISalaService, SalaService>();
            services.AddScoped<ICidadeService, CidadeService>();

            //ApplicationServices
            services.AddScoped<IFilmeAppService, FilmeAppService>();
            services.AddScoped<ICinemaAppService, CinemaAppService>();
            services.AddScoped<ISessaoAppService, SessaoAppService>();
            services.AddScoped<ICidadeAppService, CidadeAppService>();

        }
    }
}
