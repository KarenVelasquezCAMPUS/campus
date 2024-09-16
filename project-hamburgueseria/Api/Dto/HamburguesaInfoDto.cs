namespace Api.Dto;
public class HamburguesaInfoDto : HamburguesaDto
{
    public CategoriaDto Categoria { get; set; }
    public ChefDto Chef { get; set; }
    public List<IngredienteDto> Ingredientes { get; set; }
}