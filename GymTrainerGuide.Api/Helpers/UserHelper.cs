using GymTrainerGuide.Api.Data;
using GymTrainerGuide.Shared.DTOs;
using GymTrainerGuide.Api.Helpers;
using GymTrainerGuide.Shared.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GymTrainerGuide.Api.Helper
{

    public class UserHelper : IUserHelper
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Usuario> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<Usuario> _signInManager;

        public UserHelper(ApplicationDbContext context, UserManager<Usuario> userManager, RoleManager<IdentityRole> roleManager, SignInManager<Usuario> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> AddUserAsync(Usuario user, string password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        public async Task AddUserToRoleAsync(Usuario user, string roleName)
        {
            await _userManager.AddToRoleAsync(user, roleName);
        }

        public async Task CheckRoleAsync(string roleName)
        {
            bool roleExists = await _roleManager.RoleExistsAsync(roleName);
            if (!roleExists)
            {
                await _roleManager.CreateAsync(new IdentityRole
                {
                    Name = roleName
                });
            }
        }

        public async Task<Usuario> GetUserAsync(string email)
        {

            return await _userManager.FindByEmailAsync(email);

        }

        public async Task<bool> IsUserInRoleAsync(Usuario user, string roleName)
        {

            return await _userManager.IsInRoleAsync(user, roleName);

        }

        public async Task<SignInResult> LoginAsync(LoginDTO model)
        {

            return await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

        }

        public async Task LogoutAsync()
        {

            await _signInManager.SignOutAsync();

        }

        public async Task<Usuario> GetUserAsync(Guid userId)
        {

            return await _userManager.FindByIdAsync(userId.ToString());

        }


        public async Task<IdentityResult> ChangePasswordAsync(Usuario user, string currentPassword, string newPassword)
        {

            return await _userManager.ChangePasswordAsync(user, currentPassword, newPassword);

        }

        public async Task<IdentityResult> UpdateUserAsync(Usuario user)
        {

            return await _userManager.UpdateAsync(user);

        }
    }
}
