using ChiquePrinter.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChiquePrinter.WPF.State.Users
{
    public interface IUserStore
    {
        User CurrentUser { get; set; }
        event Action StateChanged;
    }
}
