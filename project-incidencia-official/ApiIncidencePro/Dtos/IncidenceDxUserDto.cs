namespace ApiIncidencePro.Dtos;
public class IncidenceDxUserDto
{
    public int IncidenceDxUserId { get; set; }
    public string IncidenceDxUserName { get; set; }
    public string IncidenceDxUserDescription { get; set; }
    public List<UserDto> Users { get; set; }
    public List<IncidenceDetailDto> IncidenceDetails { get; set; }

}