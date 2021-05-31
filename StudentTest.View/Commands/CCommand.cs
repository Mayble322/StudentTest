﻿using StudentTest.View.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest.View.Commands
{
    public class CCommand : AsyncCommandBase
    {
        private readonly UserViewModel _userViewModel;
        public CCommand(UserViewModel userViewModel)
        {
            this._userViewModel = userViewModel;
        }

        public async override Task ExecuteAsync(object parameter)
        {
            try
            {
                if (_userViewModel.Category2.Quiz.AnswerC == _userViewModel.Category2.Quiz.CorrectAnswer)
                {
                    _userViewModel.CountRightAnswer += 1;
                }

            }
            catch (Exception)
            {
                _userViewModel.ErrorMessage = "Fail";
            }
        }
    }
}
