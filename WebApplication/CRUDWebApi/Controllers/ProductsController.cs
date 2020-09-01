using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new List<Product>()
        {
            new Product
            {
                Id = 1006368,
                Name = "Austin and Barbeque AABQ Wifi Food Thermometer",
                Description = "Termometer with Wifi for an optimal InnerTemperatur",
                Price = 399
            },

            new Product
            {
                Id = 1009334,
                Name = "Andersson Elektrisk Lighter ECL 1.1",
                Description = "Elektrisk Lighterwithout gas and fuel ",
                Price = 89
            },

            new Product
            {
                Id = 1002266,
                Name = "Weber non-Stick Spray",
                Description = "BBQ- oilspray which prevent raw materials from sticking to the grid  ",
                Price =99
            }

        };

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            var product = products.Find(product => product.Id == id);
            return product;
        }

    }
}
