namespace Application.Models;

public class ContactModel
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string Message { get; set; }
}