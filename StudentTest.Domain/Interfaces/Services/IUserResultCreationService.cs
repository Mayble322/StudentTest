using StudentTest.Domain.Entities;
using StudentTest.Domain.Entities.QuizEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest.Domain.Interfaces.Services
{
    public enum CreationUserResultResult
    {
        SuccessCreation,
        EmptyData
    }
    public interface IUserResultCreationService
    {
        Task<UserResult> Creation(Account account, int countCorrectAnswer, int countQuestions);
    }
}
