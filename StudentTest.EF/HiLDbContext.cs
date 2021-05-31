using Microsoft.EntityFrameworkCore;
using StudentTest.Domain.Entities;
using StudentTest.Domain.Entities.QuizEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTest.EF
{
    public class HiLDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<CategoryQuiz> CategoryQuizzes { get; set; }
        public DbSet<CountQuestions> CountOfQuestions { get; set; }
        public DbSet<UserResult> UserResults { get; set; }


        public HiLDbContext(DbContextOptions options) : base(options)
        {

        }

    }
}
