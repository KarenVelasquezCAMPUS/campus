/* using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;
[Route("[controller]")]
public class HamburguesaController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;

    public HamburguesaController(IUnitOfWork unitOfWork)
    {
        this._unitOfWork = unitOfWork;
    }
    // [GET] Retorna todos los registros contenidos en la tabla 
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Hamburguesa>>> Get()
    {
        var hamburguesas = await _unitOfWork.Hamburguesas.GetAllAsync();
        return Ok(hamburguesas);
    }
    // [GET] Permite retornar un registro especifico apartir del id principal
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetId(int id)
    {
        var hamburguesas = await _unitOfWork.Hamburguesas.GetByIdAsync(id);
        return Ok(hamburguesas);
    } 
    // [POST]
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Hamburguesa>> Post(Hamburguesa hamburguesa){
        this._unitOfWork.Hamburguesas.Add(hamburguesa);
        await _unitOfWork.SaveAsync();
        if (hamburguesa == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new {id = hamburguesa.Id}, hamburguesa); 
    }
    // [PUT]
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Hamburguesa>> Put(int id, [FromBody]Hamburguesa hamburguesa){
        if(hamburguesa == null)
            return NotFound();
        _unitOfWork.Hamburguesas.Update(hamburguesa);
        await _unitOfWork.SaveAsync();
        return hamburguesa;
    }
    // [DELETE]
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
        var hamburguesa = await _unitOfWork.Hamburguesas.GetByIdAsync(id);
        if(hamburguesa == null){
            return NotFound();
        }
        _unitOfWork.Hamburguesas.Remove(hamburguesa);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
} */