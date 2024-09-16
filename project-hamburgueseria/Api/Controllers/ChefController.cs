/* using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;
[Route("[controller]")]
public class ChefController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;

    public ChefController(IUnitOfWork unitOfWork)
    {
        this._unitOfWork = unitOfWork;
    }
    // [GET] Retorna todos los registros contenidos en la tabla 
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Chef>>> Get()
    {
        var chefs = await _unitOfWork.Chefs.GetAllAsync();
        return Ok(chefs);
    }
    // [GET] Permite retornar un registro especifico apartir del id principal
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetId(int id)
    {
        var chefs = await _unitOfWork.Chefs.GetByIdAsync(id);
        return Ok(chefs);
    } 
    // [POST]
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Hamburguesa>> Post(Chef chef){
        this._unitOfWork.Chefs.Add(chef);
        await _unitOfWork.SaveAsync();
        if (chef == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new {id = chef.Id}, chef); 
    }
    // [PUT]
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Chef>> Put(int id, [FromBody]Chef chef){
        if(chef == null)
            return NotFound();
        _unitOfWork.Chefs.Update(chef);
        await _unitOfWork.SaveAsync();
        return chef;
    }
    // [DELETE]
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
        var chef = await _unitOfWork.Chefs.GetByIdAsync(id);
        if(chef == null){
            return NotFound();
        }
        _unitOfWork.Chefs.Remove(chef);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
} */