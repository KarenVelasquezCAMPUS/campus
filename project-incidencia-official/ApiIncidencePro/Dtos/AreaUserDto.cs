namespace ApiIncidencePro.Dtos;
public class AreaUserDto
{
  public int AreaUserId { get; set; }
  public List<UserDto> Users { get; set; }  
  public List<AreaDto> Areas { get; set; }  
}