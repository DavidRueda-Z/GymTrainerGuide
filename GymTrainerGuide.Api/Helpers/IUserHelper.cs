using Microsoft.AspNetCore.Identity;
using GymTrainerGuide.Shared.DTOs;
using GymTrainerGuide.Shared.Entities;

namespace GymTrainerGuide.Api.Helpers
{
    public interface IUserHelper
    {
        Task<Usuario> GetUserAsync(string email);

        Task<IdentityResult> AddUserAsync(Usuario user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(Usuario user, string roleName);

        Task<bool> IsUserInRoleAsync(Usuario user, string roleName);

        Task<SignInResult> LoginAsync(LoginDTO model);

        Task LogoutAsync();
        Task<IdentityResult> UpdateUserAsync(Usuario user);

        Task<Usuario> GetUserAsync(Guid userId);

        Task<IdentityResult> ChangePasswordAsync(Usuario user, string currentPassword, string newPassword);
    }
}
