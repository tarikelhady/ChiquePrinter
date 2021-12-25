using ChiquePrinter.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiquePrinter.WPF.ViewModels.Factories
{
    public interface IChiquePrinterViewModelFactory
    {
        ViewModelBase CreateViewModel(ViewType viewType);
    }
}
