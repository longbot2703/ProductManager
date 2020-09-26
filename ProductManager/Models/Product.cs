using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProductManager.Models
{
    public class Product
    {
        public string Id { get; set; }

        [JsonPropertyName("Img")]

        public string Image { get; set; }

        public string Name { get; set; }
        public string Price { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
