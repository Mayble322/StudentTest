using StudentTest.Domain.Entities.QuizEntities;
using StudentTest.Domain.Interfaces.Repository;
using StudentTest.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest.Domain.Services
{
    public class CountQuestionsCreationService : ICountQuestionsCreationService
    {

        private readonly ICountQuestionsService _countQuestionsService;

        public CountQuestionsCreationService(ICountQuestionsService countQuestionsService)
        {
            _countQuestionsService = countQuestionsService;
        }

        public async Task<CreationCountQuestionsResult> Creation(string countOfQuestions)
        {

            CreationCountQuestionsResult result = CreationCountQuestionsResult.SuccessCreation;

            if (countOfQuestions == null)
            {
                result = CreationCountQuestionsResult.EmptyData;
            }

            if (result == CreationCountQuestionsResult.SuccessCreation)
            {
                var countQuestions = await _countQuestionsService.Get(1);


                if (countQuestions == null)
                {
                    var c = new CountQuestions
                    {
                        CountOfQuestions = Convert.ToInt32(countOfQuestions)
                    };

                    await _countQuestionsService.Create(c);
                }
                else
                {
                    var c = new CountQuestions
                    {
                        CountOfQuestions = Convert.ToInt32(countOfQuestions)
                    };

                    await _countQuestionsService.Update(1, c);
                }

            }
            return result;
        }
    }
}
