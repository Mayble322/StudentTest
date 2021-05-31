using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTest.Domain.Entities.QuizEntities
{
    public class Quiz : ObjectId
    {
        public string Question { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public string CorrectAnswer { get; set; }

    }
}
