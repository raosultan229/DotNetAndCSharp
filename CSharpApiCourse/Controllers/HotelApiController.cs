using AutoMapper;
using CSharpApiCourse.Data;
using CSharpApiCourse.Models;
using CSharpApiCourse.Models.Dto;
using CSharpApiCourse.Repository.IRepository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace CSharpApiCourse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelApiController : ControllerBase
    {
        private readonly IHotelRepository _dbHotel;
        private readonly IMapper _mapper;
        protected APIResponse _response;
        public HotelApiController(IHotelRepository dbHotel, IMapper mapper)
        {
            _dbHotel = dbHotel;
            _mapper = mapper;
            this._response = new();
        }
        //Logging--Errors
        private readonly ILogger<HotelApiController> _logger;
        public ILogger<HotelApiController> Logger { get; }

        //GetAll
        [HttpGet]
        public async Task<ActionResult<APIResponse>> GetHotels()
        {
            try
            {

                IEnumerable<Hotel> hotelList = await _dbHotel.GetAllHotelAsync();
                _response.Result = _mapper.Map<List<HotelDTO>>(hotelList);
                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpGet("{id:int}", Name = "GetHotel")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        //GetById
        public async Task<ActionResult<APIResponse>> GetHotelById(int id)
        {
            try
            {
                if (id == 0)
                {
                    _logger.LogError("Your id is incorrect");
                    return BadRequest();
                }
                var hotell = await _dbHotel.GetHotelAsync(u => u.Id == id);
                if (hotell == null)
                {
                    return NotFound();
                }
                _response.Result = _mapper.Map<HotelDTO>(hotell);
                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }

        //Create
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult<APIResponse>> CreateHotel([FromBody] HotelCreateDTO createDTO)
        {
            try
            {

                if (await _dbHotel.GetHotelAsync(u => u.Name.ToLower() == createDTO.Name.ToLower()) != null)
                {
                    ModelState.AddModelError("CustomError", "Name already taken");
                    return BadRequest(ModelState);
                }
                if (createDTO == null)
                {
                    return BadRequest(createDTO);
                }
                Hotel model = _mapper.Map<Hotel>(createDTO);
                await _dbHotel.CreateAsync(model);

                _response.Result = _mapper.Map<HotelDTO>(model);
                _response.IsSuccess = true;
                _response.StatusCode = HttpStatusCode.Created;
                return CreatedAtRoute("GetHotel", new { id = model.Id }, _response);
            
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;

        }

        //Delelte
        [HttpDelete("{id:int}", Name = "DeleteHotel")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> DeleteHotel(int id)
        {
            try
            {

                if (id == 0) 
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var hotell = await _dbHotel.GetHotelAsync(u => u.Id == id);
                if (hotell == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                await _dbHotel.RemoveAsync(hotell);
                _response.IsSuccess = true;
                _response.StatusCode = HttpStatusCode.NoContent;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }


        //UpdateAll
        [HttpPut("{id:int}", Name = "UpdateHotel")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> UpdateHotel(int id, [FromBody] HotelUpdateDTO updateDTO)
        {
            try
            {
                if (updateDTO == null || id != updateDTO.Id)
                {

                    return BadRequest();
                }
                Hotel model = _mapper.Map<Hotel>(updateDTO);
                await _dbHotel.UpdateAsync(model);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
       
        //UpdateById
        [HttpPatch("{id:int}", Name = "UpdateSingleHotel")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> UpdateSingleHotel(int id, JsonPatchDocument<HotelUpdateDTO> patchDTO)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }
                var hotell = await _dbHotel.GetHotelAsync(u => u.Id == id, tracked: false);
                HotelUpdateDTO hotelDTO = _mapper.Map<HotelUpdateDTO>(hotell);
                if (hotell == null)
                {
                    return BadRequest();
                }

                patchDTO.ApplyTo(hotelDTO, ModelState);
                Hotel model = _mapper.Map<Hotel>(hotelDTO);
                await _dbHotel.UpdateAsync(model);
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
            
        }
    }
}