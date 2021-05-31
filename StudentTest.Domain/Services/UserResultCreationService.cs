using StudentTest.Domain.Entities;
using StudentTest.Domain.Entities.QuizEntities;
using StudentTest.Domain.Interfaces.Repository;
using StudentTest.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest.Domain.Services
{
    public class UserResultCreationService : IUserResultCreationService
    {
        private readonly IUserResultService _userResultService;
        public UserResultCreationService(IUserResultService userResultService)
        {
            _userResultService = userResultService;
        }

        public async Task<UserResult> Creation(Account account, int countCorrectAnswer, int countQuestions)
        {
            CreationUserResultResult result = CreationUserResultResult.SuccessCreation;

            var userResult = new UserResult();

            if (account == null || countCorrectAnswer == 0 || countQuestions == 0)
            {
                result = CreationUserResultResult.EmptyData;
            }

            if (result == CreationUserResultResult.SuccessCreation)
            {

                userResult = new UserResult()
                {
                    UserID = account.UserID,
                    CountOfCorrectAnswer = countCorrectAnswer,
                    CountOfQuestions = countQuestions
                };

                await _userResultService.Create(userResult);


            }

            return userResult;
        }
    }
}
