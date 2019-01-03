using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Ingresso.Com.Application.Configuration
{
    public static class AutoMapperConfig
    {
        public static void InicializeMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new DomainToModelMappingProfile());
            });
        }
    }
}
