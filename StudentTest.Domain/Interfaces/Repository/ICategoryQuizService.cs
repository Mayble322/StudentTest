﻿using StudentTest.Domain.Entities.QuizEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest.Domain.Interfaces.Repository
{
    public interface ICategoryQuizService : IGenericDataService<CategoryQuiz>
    {
        Task<CategoryQuiz> GetQuizByCategory(Category entity);

        List<CategoryQuiz> GetQuizByCategory2(Category entity);
    }
}
