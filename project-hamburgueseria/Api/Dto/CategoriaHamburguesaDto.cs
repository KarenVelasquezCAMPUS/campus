using Dominio.Entities;

namespace Api.Dto;
public class CategoriaHamburguesaDto : CategoriaDto
{
    public List<Hamburguesa> Hamburguesas { get; set; }
}