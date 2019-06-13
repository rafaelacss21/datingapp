using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
 public class UserForRegisterDto
 {
  [Required]
  public string Username { get; set; }

  [Required]
  [StringLength(8, MinimumLength = 6, ErrorMessage = "Password must have 6 characters or more")]
  public string Password { get; set; }
 }
}