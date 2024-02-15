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
    [Route("api/HotelNumberApi")]
    [ApiController]
    public class HotelNumberApiController : ControllerBase
    {
        private readonly IHotelNumberRepository _dbHotelNmuber;
        private readonly IMapper _mapper;
        protected APIResponse _response;
       
        public HotelNumberApiController(IHotelNumberRepository dbHotelNumber, IMapper mapper)
        {
            _dbHotelNmuber = dbHotelNumber;
            _mapper = mapper;
            this._response = new();
        }
        //private readonly ILogger<HotelNumberApiController> _logger;
        //public Ilogger<HotelNumberApiController> Logger { get; }

        [HttpGet]
        public async Task<ActionResult<APIResponse>> GetHotelNumbers()
        {
            try
            {
                IEnumerable<HotelNumber> hotelNumberList = await _dbHotelNmuber.GetAllHotelAsync();
                _response.Result = _mapper.Map<List<HotelNumberDTO>>(hotelNumberList);
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

        [HttpGet("{id:int}", Name="GetNumberHotel")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<APIResponse>> GetHotelById(int id)
        {
            try
            {
                if (id == 0)
                {
                    //_logger.LogError("Your id is incorrect");
                    return BadRequest();
                }
                var hotell = await _dbHotelNmuber.GetHotelAsync(u => u.HotelNo == id);

                if (hotell == null) {
                    return NotFound();
                }
                _response.Result = _mapper.Map<HotelNumberDTO>(hotell);
                _response.IsSuccess = true;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult<APIResponse>> CreateHotelNumber([FromBody] HotelNumberCreateDTO createDTO)
        {
            try
            {
                if(await _dbHotelNmuber.GetHotelAsync(u => u.HotelNo == createDTO.HotelNo) !=null){
                    ModelState.AddModelError("Custom Error", "Hotel Number already exist");
                    return BadRequest(ModelState);
                }
                if(createDTO == null)
                {
                    return BadRequest(createDTO);
                }
                HotelNumber model = _mapper.Map<HotelNumber>(createDTO);
                await _dbHotelNmuber.CreateAsync(model);    
                _response.Result = _mapper.Map<HotelNumberDTO>(model);
                _response.IsSuccess = true;
                _response.StatusCode = HttpStatusCode.Created;
                return CreatedAtRoute("GetHotelNumber", new { id = model.HotelNo }, _response);

            }   
            catch(Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }

    }
}