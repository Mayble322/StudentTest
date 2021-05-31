using StudentTest.Domain.Entities.QuizEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest.Domain.Interfaces.Services
{
    public enum CreationQuizResult
    {
        SuccessCreation,
        CorrectAnswerDoNotMatch,
        QuestionAlreadyExists,
        EmptyData
    }

    public interface IQuizCreationService
    {
        Task<CreationQuizResult> Creation(string question, string answerA, string answerB, string answerC, string answerD, string correctAnswer, Category category);
    }
}
