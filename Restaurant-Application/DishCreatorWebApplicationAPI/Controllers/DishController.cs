using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DishCreatorLibrary;
using DishCreatorWebApplicationAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DishCreatorWebApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishController : ControllerBase
    {
        // GET: api/Dish
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Dish/5
        [HttpGet("{id}", Name = "Get")]
        public Dish Get(int id, [FromBody] DishParameters dish)
        {
            InitializeDishes initializeDishes = new InitializeDishes();

            //DishParameters dish =   JsonConvert.DeserializeObject<DishParameters>(value);
            Appetizer appetizer = initializeDishes.InitializeAppetizer(dish.Name, dish.Quantity, dish.DinerSerialNumber, eAppetizerTypes.ChickenNuggets);

            return appetizer;
        }

        // POST: api/Dish
        [HttpPost]
        public Dish Post([FromBody] DishParameters dish)
        {
            InitializeDishes initializeDishes = new InitializeDishes();

            //DishParameters dish =   JsonConvert.DeserializeObject<DishParameters>(value);
            Appetizer appetizer = initializeDishes.InitializeAppetizer(dish.Name, dish.Quantity, dish.DinerSerialNumber, eAppetizerTypes.ChickenSkewers);

            return appetizer;
        }

        // PUT: api/Dish/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
