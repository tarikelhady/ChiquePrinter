using Microsoft.AspNet.Identity;
using ChiquePrinter.Domain.Exceptions;
using ChiquePrinter.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChiquePrinter.Domain.Services.AuthenticationServices
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserService _UserService;
        private readonly IPasswordHasher _passwordHasher;

        public AuthenticationService(IUserService UserService, IPasswordHasher passwordHasher)
        {
            _UserService = UserService;
            _passwordHasher = passwordHasher;
        }

        public async Task<User> Login(string username, string password)
        {
            User storedUser = await _UserService.GetByUsername(username);

            if(storedUser == null)
            {
                throw new UserNotFoundException(username);
            }

            PasswordVerificationResult passwordResult = _passwordHasher.VerifyHashedPassword(storedUser.Password, password);

            if(passwordResult != PasswordVerificationResult.Success)
            {
                throw new InvalidPasswordException(username, password);
            }

            return storedUser;
        }

        public async Task<RegistrationResult> Register(string email, string username, string password, string confirmPassword)
        {
            RegistrationResult result = RegistrationResult.Success;

            if(password != confirmPassword)
            {
                result = RegistrationResult.PasswordsDoNotMatch;
            }

            User emailUser = await _UserService.GetByEmail(email);
            if(emailUser != null)
            {
                result = RegistrationResult.EmailAlreadyExists;
            }

            User usernameUser = await _UserService.GetByUsername(username);
            if (usernameUser != null)
            {
                result = RegistrationResult.UsernameAlreadyExists;
            }

            if(result == RegistrationResult.Success)
            {
                string hashedPassword = _passwordHasher.HashPassword(password);

                User user = new User()
                {
                    Email = email,
                    Username = username,
                    Password = hashedPassword
                };

                await _UserService.Create(user);
            }

            return result;
        }
    }
}
