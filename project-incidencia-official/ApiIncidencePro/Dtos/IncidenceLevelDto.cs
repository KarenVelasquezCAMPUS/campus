namespace ApiIncidencePro.Dtos;
public class IncidenceLevelDto
{
  public int IncidenceLevelId { get; set; }
  public string IncidenceLevelName { get; set; }
  public string IncidenceLevelDescription { get; set; }
  public List<IncidenceDetailDto> IncidenceDetails { get; set; }
}