namespace ApiIncidencePro.Dtos;
public class RoleDto
{
  public int RoleId { get; set; }
  public string RoleName { get; set; }
  public string RoleDescription { get; set; }
  public List<UserDto> Users { get; set; }
}