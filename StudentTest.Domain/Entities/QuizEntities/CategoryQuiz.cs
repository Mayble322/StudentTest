using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentTest.Domain.Entities.QuizEntities
{
    public class CategoryQuiz : ObjectId
    {
        public int? CategoryID { get; set; }

        [ForeignKey(nameof(CategoryID))]
        public Category Category { get; set; }

        public int? QuizID { get; set; }

        [ForeignKey(nameof(QuizID))]
        public Quiz Quiz { get; set; }


        public override string ToString()
        {
            return Quiz.Question;
        }

    }
}
