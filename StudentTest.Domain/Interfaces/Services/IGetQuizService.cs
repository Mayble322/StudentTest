using StudentTest.Domain.Entities.QuizEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTest.Domain.Interfaces.Services
{
    public enum GetQuizResult
    {
        Success,
        DoNotChooseCategory
    }
    public interface IGetQuizService
    {
        List<CategoryQuiz> GetQuiz(Category entity, int count);
    }
}
