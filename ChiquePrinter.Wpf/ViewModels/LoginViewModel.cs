using ChiquePrinter.WPF.Commands;
using ChiquePrinter.WPF.State.Authenticators;
using ChiquePrinter.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ChiquePrinter.WPF.ViewModels
{
	public class LoginViewModel : ViewModelBase
	{
		private string _username = "mohsen";
		public string Username
		{
			get
			{
				return _username;
			}
			set
			{
				_username = value;
				OnPropertyChanged(nameof(Username));
				OnPropertyChanged(nameof(CanLogin));
			}
		}

		private string _password = "123456";
		public string Password
		{
			get
			{
				return _password;
			}
			set
			{
				_password = value;
				OnPropertyChanged(nameof(Password));
				OnPropertyChanged(nameof(CanLogin));
			}
		}

		public bool CanLogin => !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);

		public MessageViewModel ErrorMessageViewModel { get; }

		public string ErrorMessage
		{
			set => ErrorMessageViewModel.Message = value;
		}

		public ICommand LoginCommand { get; }
		public ICommand ViewRegisterCommand { get; }

		public LoginViewModel(IAuthenticator authenticator, IRenavigator loginRenavigator)
		{
			ErrorMessageViewModel = new MessageViewModel();

			LoginCommand = new LoginCommand(this, authenticator, loginRenavigator);
		}

		public override void Dispose()
		{
			ErrorMessageViewModel.Dispose();

			base.Dispose();
		}
	}
}
