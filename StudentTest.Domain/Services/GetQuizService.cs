using StudentTest.Domain.Entities.QuizEntities;
using StudentTest.Domain.Interfaces.Repository;
using StudentTest.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTest.Domain.Services
{
    public class GetQuizService : IGetQuizService
    {
        private readonly ICategoryQuizService _categoryQuizService;
        private readonly ICountQuestionsService _countQuestionsService;

        private static Random rng = new Random();

        public GetQuizService(ICategoryQuizService categoryQuizService, ICountQuestionsService countQuestionsService)
        {
            this._categoryQuizService = categoryQuizService;
            this._countQuestionsService = countQuestionsService;
        }

        public List<CategoryQuiz> GetQuiz(Category category, int count)
        {
            List<CategoryQuiz> q = _categoryQuizService.GetQuizByCategory2(category);

            for (int i = q.Count; i > count; i--)
            {
                int index = rng.Next(q.Count);
                CategoryQuiz question = q[index];
                q.RemoveAt(index);
            }

            return q;
        }
    }
}
