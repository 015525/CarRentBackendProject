using System.ComponentModel.DataAnnotations;

namespace TawsilaBackend.Models.Users;

public record RegisterRequest(
    [Required] string Email,
    [Required] string Password,
    [Required] string FirstName,
    [Required] string LastName,
    [Required] string Phone,
    [Required] bool HasWhatsapp,
    [Required] string Governorate
);