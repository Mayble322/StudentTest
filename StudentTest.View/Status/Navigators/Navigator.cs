using StudentTest.View.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTest.View.Status.Navigators
{
    public class Navigator : INavigator
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                StateChanged?.Invoke();
            }
        }

        public event Action StateChanged;

    }
}
