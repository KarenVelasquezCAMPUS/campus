namespace ApiIncidencePro.Dtos;
public class DocTypeDto
{
  public int DocTypeId { get; set; }
  public string DocTypeName { get; set; }
  public List<ContactTypeDto> ContactTypes { get; set; }
  public List<UserDto> Users { get; set; }
}