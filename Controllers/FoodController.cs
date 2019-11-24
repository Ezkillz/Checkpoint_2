using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FoodStorage.Core.Services;
using CS321_FoodStorage_Checkpoint2.Models;
using CS321_FoodStorage_Checkpoint2.ApiModels;

namespace CS321_FoodStorage_Checkpoint2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : Controller
    {
        private readonly IFoodService _foodService;
        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }


        [HttpGet()]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_foodService.GetAll());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("GetFoods", ex.Message);
                return BadRequest(ModelState);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var food = _foodService.Get(id);
                if (food == null) return NotFound();
                return Ok(food);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Get Food", ex.Message);
                return BadRequest(ModelState);
            }
        }

        [HttpPost]
        public IActionResult Add([FromBody] FoodModel food)
        {
            try
            {
                return Ok(_foodService.Add(food.ToDomainModel()));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("AddFood", ex.Message);
                return NotFound(ModelState);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] FoodModel food)
        {
            ModelState.AddModelError("UpdateFood", "Not Implemented!");
            return BadRequest(ModelState);
        }

        [HttpDelete]
        public IActionResult Remove()
        {
            ModelState.AddModelError("RemoveFood", "Not Implemented!");
            return BadRequest(ModelState);
        }
    }
}
