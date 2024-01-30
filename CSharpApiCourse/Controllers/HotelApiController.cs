using CSharpApiCourse.Data;
using CSharpApiCourse.Models;
using CSharpApiCourse.Models.Dto;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CSharpApiCourse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelApiController : ControllerBase
    {
        //Logging--Errors
        private readonly ILogger<HotelApiController> _logger;
        public ILogger<HotelApiController> Logger { get; }
        public HotelApiController(ILogger<HotelApiController> logger)
        {
            _logger = logger;
        }

        //GetAll
        [HttpGet]
        public ActionResult<IEnumerable<HotelDTO>> GetHotels()
        {
            return Ok(HotelStore.hotelList);
        }
        [HttpGet("{id:int}", Name = "GetHotel")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        //GetById
        public ActionResult<HotelDTO> GetHotelById(int id)
        {
            if (id == 0)
            {
                _logger.LogError("Your id is incorrect");
                return BadRequest();
            }
            var hotell = HotelStore.hotelList.FirstOrDefault(u => u.Id == id);
            if (hotell == null)
            {
                return NotFound();
            }

            return Ok(hotell);
        }

        //Create
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public ActionResult<HotelDTO> CreateHotel([FromBody] HotelDTO hotelDTO)
        {
            if (HotelStore.hotelList.FirstOrDefault(u => u.Name.ToLower() == hotelDTO.Name.ToLower()) != null)
            {
                ModelState.AddModelError("CustomError", "Name already taken");
                return BadRequest(ModelState);
            }
            if (hotelDTO == null)
            {
                return BadRequest(hotelDTO);
            }
            if (hotelDTO.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            hotelDTO.Id = HotelStore.hotelList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
            HotelStore.hotelList.Add(hotelDTO);
            return CreatedAtRoute("GetHotel", new { id = hotelDTO.Id }, hotelDTO);

        }

        //Delelte
        [HttpDelete("{id:int}", Name = "DeleteHotel")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteHotel(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var hotell = HotelStore.hotelList.FirstOrDefault(u => u.Id == id);
            if (hotell == null)
            {
                return NotFound();
            }
            HotelStore.hotelList.Remove(hotell);
            return NoContent();
        }


        //UpdateAll
        [HttpPut("{id:int}", Name="UpdateHotel")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateHotel(int id, [FromBody]HotelDTO hotelDTO) { 
            if(hotelDTO==null || id != hotelDTO.Id)
            {
                return BadRequest();
            }
            var hotell = HotelStore.hotelList.FirstOrDefault(u => u.Id == id);
            hotell.Name = hotelDTO.Name;
            hotell.Rooms = hotelDTO.Rooms;
            hotell.Description = hotelDTO.Description; 
            hotell.IsAvailable = hotelDTO.IsAvailable;

            return NoContent();
        }

        //UpdateById
        [HttpPatch("{id:int}", Name = "UpdateSingleHotel")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult UpdateSingleHotel(int id, JsonPatchDocument<HotelDTO> patchDTO) {
            if (id == 0 || patchDTO ==null) {
                return BadRequest();
            }
            var hotell = HotelStore.hotelList.FirstOrDefault(u=>u.Id == id);
            if(hotell == null)
            {
                return BadRequest();
            }
            patchDTO.ApplyTo(hotell, ModelState);
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            return NoContent() ;
        }
    }
}