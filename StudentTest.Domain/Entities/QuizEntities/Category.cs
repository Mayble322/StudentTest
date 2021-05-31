using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTest.Domain.Entities.QuizEntities
{
    public class Category : ObjectId
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
