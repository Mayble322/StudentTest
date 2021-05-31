using StudentTest.Domain.Entities.QuizEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest.Domain.Interfaces.Repository
{
    public interface ICategoryService : IGenericDataService<Category>
    {
        Task<Category> GetByCategory(string categoryName);
    }
}
