using System;
using AutoMapper;
using CodeBridgeApi.Dtos;
using CodeBridgeApi.Models;

namespace CodeBridgeApi.Mapper
{
    public class Mapping : Profile
    {        
        public Mapping()
        {            
            CreateMap<DogsModel, DogsDto>();
            CreateMap<AddDogsDto, DogsModel>();
        }
    }
}

