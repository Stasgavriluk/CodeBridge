using System;
using CodeBridgeApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeBridgeApi.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}       

        public DbSet<DogsModel> DogsModels { get; set; }
    }
}

