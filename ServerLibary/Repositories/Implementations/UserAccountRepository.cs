using BaseLibary.DTOs;
using BaseLibary.Entities;
using BaseLibary.Responses;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ServerLibary.Data;
using ServerLibary.Helpers;
using ServerLibary.Repositories.Contracts;
using System.Reflection.Metadata;

namespace ServerLibary.Repositories.Implementations
{
    public class UserAccountRepository(IOptions<JwtSection> config, AppDbContext appContext) : IUserAccount
    {
        public async Task<GeneralResponse> CreateAsync(Register user)
        {
            if (user is null) return new GeneralResponse(false, "Model is empty");

            var checkUser = await FindUserByEmail(user.Email!);
            if (checkUser != null) return new GeneralResponse(false, "User registered already");

            //Save user
            var applicationUser = await AddToDatabase(new ApplicationUser()
            {
                FullName = user.Fullname,
                Email = user.Email,
                Password = BCrypt.Net.BCrypt.HashPassword(user.Password)
            });

            // check, create and assing role
            var checkAdminRole = await appContext.systemRoles.FirstOrDefaultAsync(x => x.Name!.Equals(Constants.AdminRole));
            if (checkAdminRole is null) 
            { 
                var createAdminRole 
            }
        }

        public Task<LoginResponse> SignInAsync(Login user)
        {
            throw new NotImplementedException();
        }

        private async Task<ApplicationUser> FindUserByEmail(string email) =>
            await appContext.applicationUsers.FirstOrDefaultAsync(x => x.Email!.ToLower()!.Equals(email!.ToLower()));

        private async Task<T> AddToDatabase<T>(T model)
        {
            var result = appContext.Add(model!);
            await appContext.SaveChangesAsync();
            return (T)result.Entity;
        }
    }
}
