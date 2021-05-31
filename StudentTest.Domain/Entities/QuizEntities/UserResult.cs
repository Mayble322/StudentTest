using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentTest.Domain.Entities.QuizEntities
{
    public class UserResult : ObjectId
    {
        public int? UserID { get; set; }

        [ForeignKey(nameof(UserID))]
        public User User { get; set; }

        public int CountOfCorrectAnswer { get; set; }

        public int CountOfQuestions { get; set; }
    }
}
