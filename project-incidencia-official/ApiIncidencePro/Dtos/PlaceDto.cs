namespace ApiIncidencePro.Dtos;
public class PlaceDto
{
  public int PlaceId { get; set; }
  public string PlaceName { get; set; }
  public string PlaceDescription { get; set; }
  public List<AreaDto> Areas { get; set; }
  public List<IncidenceDto> Incidences { get; set; }
}