using System;
using CodeBridgeApi.Dtos;
using CodeBridgeApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeBridgeApi.Services
{
	public interface IDogsService
	{
        Task<List<DogsDto>> Dogs();
        Task<List<DogsDto>> AddDog(AddDogsDto dogsModel);
    }
}

