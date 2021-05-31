using StudentTest.View.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTest.View.Status.Navigators
{
    public enum ViewType
    {
        Login,
        Home,
        HomeAdmin,
        HomeUser
    }

    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        event Action StateChanged;
    }
}
