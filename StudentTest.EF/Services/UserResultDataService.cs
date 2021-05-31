﻿using Microsoft.EntityFrameworkCore;
using StudentTest.Domain.Entities.QuizEntities;
using StudentTest.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest.EF.Services
{
    public class UserResultDataService : IUserResultService
    {
        private readonly HiLDbContextCreate _contextFactory;
        private readonly NonQueryDataService<UserResult> _nonQueryDataService;

        public UserResultDataService(HiLDbContextCreate contextFactory)
        {
            _contextFactory = contextFactory;
            _nonQueryDataService = new NonQueryDataService<UserResult>(contextFactory);
        }

        public async Task<UserResult> Create(UserResult entity)
        {
            return await _nonQueryDataService.Create(entity);
        }

        public async Task<bool> Delete(int id)
        {
            return await _nonQueryDataService.Delete(id);
        }

        public async Task<UserResult> Get(int id)
        {
            using (HiLDbContext context = _contextFactory.CreateDbContext())
            {
                UserResult entity = await context.UserResults
                    .FirstOrDefaultAsync((e) => e.Id == id);
                return entity;
            }
        }

        public async Task<IEnumerable<UserResult>> GetAll()
        {
            using (HiLDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<UserResult> entities = await context.UserResults
                    .ToListAsync();
                return entities;
            }
        }

        public async Task<UserResult> Update(int id, UserResult entity)
        {
            return await _nonQueryDataService.Update(id, entity);
        }
    }
}
