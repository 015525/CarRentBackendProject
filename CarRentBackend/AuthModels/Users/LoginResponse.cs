using System.ComponentModel.DataAnnotations;

namespace TawsilaBackend.Models.Users;

/// <summary>Result of logging a user in.</summary>
/// <param name = "Token">Issued JWT token.</param>
public record LoginResponse(
    [Required] string Token
);