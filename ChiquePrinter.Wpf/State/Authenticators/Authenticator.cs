using ChiquePrinter.Domain.Models;
using ChiquePrinter.Domain.Services.AuthenticationServices;
using ChiquePrinter.WPF.State.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChiquePrinter.WPF.State.Authenticators
{
    public class Authenticator : IAuthenticator
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserStore _UserStore;

        public Authenticator(IAuthenticationService authenticationService, IUserStore UserStore)
        {
            _authenticationService = authenticationService;
            _UserStore = UserStore;
        }

        public User CurrentUser
        {
            get
            {
                return _UserStore.CurrentUser;
            }
            private set
            {
                _UserStore.CurrentUser = value;
                StateChanged?.Invoke();
            }
        }

        public bool IsLoggedIn => CurrentUser != null;

        public event Action StateChanged;

        public async Task Login(string username, string password)
        {
            CurrentUser = await _authenticationService.Login(username, password);
        }

        public void Logout()
        {
            CurrentUser = null;
        }

        public async Task<RegistrationResult> Payee(string email, string username, string password, string confirmPassword)
        {
            return await _authenticationService.Register(email, username, password, confirmPassword);
        }
    }
}
