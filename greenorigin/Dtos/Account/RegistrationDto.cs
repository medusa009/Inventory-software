using System.ComponentModel.DataAnnotations;

namespace greenorigin.Dtos.Account;

public class RegistrationDto
{
    [Required(ErrorMessage = "Enter a first name")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Enter a last name")]
    public string LastName { get; set; }
    [Required(ErrorMessage = "A username is requried")]
    public string UserName { get; set; }
    [EmailAddress]
    [Required(ErrorMessage = "An Email address is required")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Enter a password")]
    public string Password { get; set; }
    
}