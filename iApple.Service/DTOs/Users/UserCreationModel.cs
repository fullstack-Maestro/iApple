namespace iApple.Service.DTOs.Users;

public class UserCreationModel
{
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Country { get; set; }
    public string Password { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public DateOnly DateOfBirth { get; set; }
}