using ChiquePrinter.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiquePrinter.WPF.State.Navigators
{
    public enum ViewType
    {
        Login,
        Home,
        Payee
    }

    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        event Action StateChanged;
    }
}
