﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CodeBridgeApi.Dtos
{
	public class DogsDto
	{
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        
        public string Color { get; set; } = string.Empty;

        [JsonPropertyName("tail_lenght")]        
        public int TailLenght { get; set; }
        
        public int Weight { get; set; }
    }
}

