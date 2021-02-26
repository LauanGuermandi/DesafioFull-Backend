using AutoMapper;
using Financeiro.Domain.Dtos.DividaDtos;
using Financeiro.Domain.Dtos.PessoaDtos;
using Financeiro.Domain.Entities;

namespace Financeiro.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            // PESSOA
            CreateMap<PessoaCreateDto, Pessoa>()
                .ReverseMap();
            CreateMap<PessoaDto, Pessoa>()
                .ReverseMap();

            // DIVIDA
            CreateMap<DividaDto, Divida>()
                .ReverseMap();
            CreateMap<DividaCreateDto, Divida>()
                .ReverseMap();
            CreateMap<DividaCalculadaDto, Divida>()
                .ReverseMap();
        }
    }
}