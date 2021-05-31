using StudentTest.View.Status.Navigators;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTest.View.ViewModels.Factories
{
    public interface IHiLViewModelFactory
    {
        ViewModelBase CreateViewModel(ViewType viewType);
    }
}
