using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FoodStorage.Core.Services;

namespace CS321_FoodStorage_Checkpoint2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodTypeController : ControllerBase
    {
        private readonly IFoodTypeService _foodTypeService;
        public FoodTypeController(IFoodTypeService foodTypeService)
        {
            _foodTypeService = foodTypeService;
        }

        [HttpGet()]
        public IActionResult GetFoodTypes()
        {
            try
            {
                return Ok(_foodTypeService.GetAll().ToApiModels());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("GetFoodType", ex.Message);
                return BadRequest(ModelState);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetFoodType(int id)
        {
            try
            {
                return Ok(_foodTypeService.Get(id).ToApiModel());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("UpdateItem", ex.Message);
                return BadRequest(ModelState);
            }
        }
    }
}
