namespace ApiIncidencePro.Dtos;
public class WorkToolDto
{
  public int WorkToolId { get; set; }
  public string WorkToolName { get; set; }
  public List<IncidenceDetailDto> IncidenceDetails { get; set; }
}