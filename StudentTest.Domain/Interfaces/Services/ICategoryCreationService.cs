using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest.Domain.Interfaces.Services
{
    public enum CreationCategoryResult
    {
        SuccessCreation,
        CategoryAlreadyExists,
        EmptyData
    }

    public interface ICategoryCreationService
    {
        Task<CreationCategoryResult> Creation(string categoryName);
    }
}
