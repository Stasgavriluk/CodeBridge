using System;
using AutoMapper;
using CodeBridgeApi.Data;
using CodeBridgeApi.Dtos;
using CodeBridgeApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeBridgeApi.Services
{
    public class DogsService : IDogsService
    {
        private static List<DogsModel> dogs = new List<DogsModel>
            {
                new DogsModel
                {
                    Id = 1,
                    Name = "Puff",
                    Color = "Red",
                    TailLenght = 33,
                    Weight = 14
                },
                new DogsModel
                {
                    Id = 2,
                    Name = "Bear",
                    Color = "Green",
                    TailLenght = 22,
                    Weight = 17
                },
                new DogsModel
                {
                    Id = 3,
                    Name = "Mya",
                    Color = "Dark",
                    TailLenght = 41,
                    Weight = 21
                },
            };

        private readonly IMapper _mapper;
        private readonly DataContext _dataContext;
        public DogsService(IMapper mapper, DataContext dataContext)
        {
            _mapper = mapper;
            _dataContext = dataContext;

        }

        public async Task<List<DogsDto>> AddDog(AddDogsDto dogsModel)
        {
            var DbDogs = await _dataContext.DogsModels.ToListAsync();
            var newDog = _mapper.Map<DogsModel>(dogsModel);
            newDog.Id = dogs.Max(c => c.Id) + 1;
            dogs.Add(newDog);            
            var response =  dogs.Select(c => _mapper.Map<DogsDto>(c)).ToList();
            return response;
        }

        public async Task<List<DogsDto>> Dogs()
        {
            var DbDogs = await _dataContext.DogsModels.ToListAsync();
            var response = DbDogs.Select(c => _mapper.Map<DogsDto>(c)).ToList();
            return response;
        }
    }
}

