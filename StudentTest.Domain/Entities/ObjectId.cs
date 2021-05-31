using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudentTest.Domain.Entities
{
    public class ObjectId
    {
        [Key]
        public int Id { get; set; }
    }
}
