using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentTest.Domain.Entities
{
    public class Account : ObjectId
    {
        public int? UserID { get; set; }

        [ForeignKey(nameof(UserID))]
        public User AccountHolder { get; set; }
    }
}
