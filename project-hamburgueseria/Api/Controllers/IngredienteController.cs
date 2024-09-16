/* using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;
[Route("[controller]")]
public class IngredienteController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;

    public IngredienteController(IUnitOfWork unitOfWork)
    {
        this._unitOfWork = unitOfWork;
    }
    // [GET] Retorna todos los registros contenidos en la tabla 
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Ingrediente>>> Get()
    {
        var ingredientes = await _unitOfWork.Ingredientes.GetAllAsync();
        return Ok(ingredientes);
    }
    // [GET] Permite retornar un registro especifico apartir del id principal
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetId(int id)
    {
        var ingredientes = await _unitOfWork.Ingredientes.GetByIdAsync(id);
        return Ok(ingredientes);
    } 
    // [POST]
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Ingrediente>> Post(Ingrediente ingrediente){
        this._unitOfWork.Ingredientes.Add(ingrediente);
        await _unitOfWork.SaveAsync();
        if (ingrediente == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new {id = ingrediente.Id}, ingrediente); 
    }
    // [PUT]
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Ingrediente>> Put(int id, [FromBody]Ingrediente ingrediente){
        if(ingrediente == null)
            return NotFound();
        _unitOfWork.Ingredientes.Update(ingrediente);
        await _unitOfWork.SaveAsync();
        return ingrediente;
    }
    // [DELETE]
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
        var ingrediente = await _unitOfWork.Ingredientes.GetByIdAsync(id);
        if(ingrediente == null){
            return NotFound();
        }
        _unitOfWork.Ingredientes.Remove(ingrediente);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
} */