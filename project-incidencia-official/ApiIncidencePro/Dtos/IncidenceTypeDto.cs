namespace ApiIncidencePro.Dtos;
public class IncidenceTypeDto
{
  public int IncidenceTypeId { get; set; }
  public string IncidenceTypeName { get; set; }
  public string IncidenceTypeDescription { get; set; }
  public List<IncidenceDetailDto> IncidenceDetails { get; set; }
}