namespace iApple.Domain.Entities.User;

public class User : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public DateOnly DateOfBirth { get; set; }
}