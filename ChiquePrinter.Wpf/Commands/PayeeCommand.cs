using ChiquePrinter.Domain.Services.AuthenticationServices;
using ChiquePrinter.WPF.State.Authenticators;
using ChiquePrinter.WPF.State.Navigators;
using ChiquePrinter.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace ChiquePrinter.WPF.Commands
{
    public class PayeeCommand : AsyncCommandBase
    {
        private readonly PayeeViewModel _PayeeViewModel;
        private readonly IAuthenticator _authenticator;
        private readonly IRenavigator _payeeRenavigator;

        public PayeeCommand(PayeeViewModel PayeeViewModel, IAuthenticator authenticator, IRenavigator payeeRenavigator)
        {
            _PayeeViewModel = PayeeViewModel;
            _authenticator = authenticator;
            _payeeRenavigator = payeeRenavigator;

            _PayeeViewModel.PropertyChanged += PayeeViewModel_PropertyChanged;
        }

        public override bool CanExecute(object parameter)
        {
            return _PayeeViewModel.CanPayee && base.CanExecute(parameter);
        }

        public override async Task ExecuteAsync(object parameter)
        {
            _PayeeViewModel.ErrorMessage = string.Empty;

            try
            {
                RegistrationResult registrationResult = await _authenticator.Payee(
                       _PayeeViewModel.Email,
                       _PayeeViewModel.Username,
                       _PayeeViewModel.Password,
                       _PayeeViewModel.ConfirmPassword);

                switch (registrationResult)
                {
                    case RegistrationResult.Success:
                        _payeeRenavigator.Renavigate();
                        break;
                    case RegistrationResult.PasswordsDoNotMatch:
                        _PayeeViewModel.ErrorMessage = "Password does not match confirm password.";
                        break;
                    case RegistrationResult.EmailAlreadyExists:
                        _PayeeViewModel.ErrorMessage = "An account for this email already exists.";
                        break;
                    case RegistrationResult.UsernameAlreadyExists:
                        _PayeeViewModel.ErrorMessage = "An account for this username already exists.";
                        break;
                    default:
                        _PayeeViewModel.ErrorMessage = "Registration failed.";
                        break;
                }
            }
            catch (Exception)
            {
                _PayeeViewModel.ErrorMessage = "Registration failed.";
            }
        }

        private void PayeeViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(PayeeViewModel.CanPayee))
            {
                OnCanExecuteChanged();
            }
        }
    }
}
