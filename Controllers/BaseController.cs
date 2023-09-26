using Azure;
using BackEnd.Data;
using BackEnd.Model;
using BackEnd.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Runtime.InteropServices;

namespace BackEnd.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : BaseModel
    {
        private IRepository<T> _repository;
        private DBContext _dbContext;

        public BaseController(DBContext context, IRepository<T> repository)
        {
            _dbContext = context;
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _repository.GetAllAsync();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Error");
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _repository.GetByIdAsync(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Error");
        }
        [HttpPost]
        public async Task<IActionResult> Add(T entity)
        {
            if (entity == null)
            {
                return BadRequest("Invalid data");
            }

            try
            {
                await _repository.AddAsync(entity);
                return CreatedAtAction("GetById", new { id = entity.Id }, entity);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, T entity)
        {
            if (entity == null)
            {
                return BadRequest("Invalid data");
            }

            try
            {
                await _repository.UpdateAsync(entity, id);
                return Ok(entity);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _repository.DeleteAsync(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
       
    }
}