﻿using StudentTest.Domain.Entities.QuizEntities;
using StudentTest.Domain.Interfaces.Repository;
using StudentTest.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest.Domain.Services
{
    public class CategoryCreationService : ICategoryCreationService
    {
        private readonly ICategoryService _categoryService;

        public CategoryCreationService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        public async Task<CreationCategoryResult> Creation(string categoryName)
        {
            CreationCategoryResult result = CreationCategoryResult.SuccessCreation;

            if (categoryName == null)
            {
                result = CreationCategoryResult.EmptyData;
            }

            Category categories = await _categoryService.GetByCategory(categoryName);
            if (categories != null)
            {
                result = CreationCategoryResult.CategoryAlreadyExists;
            }

            if (result == CreationCategoryResult.SuccessCreation)
            {
                Category category = new Category()
                {
                    Name = categoryName
                };

                await _categoryService.Create(category);
            }

            return result;
        }

    }
}
