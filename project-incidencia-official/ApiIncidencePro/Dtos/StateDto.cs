namespace ApiIncidencePro.Dtos;
public class StateDto
{
  public int StateId { get; set; }
  public string StateDescription { get; set; }
  public List<IncidenceDto> Incidences { get; set; }
  public List<IncidenceDetailDto> IncidenceDetails { get; set; }
}