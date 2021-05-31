using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest.Domain.Interfaces.Services
{
    public enum CreationCountQuestionsResult
    {
        SuccessCreation,
        EmptyData
    }

    public interface ICountQuestionsCreationService
    {
        Task<CreationCountQuestionsResult> Creation(string countOfQuestions);
    }
}
