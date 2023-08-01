using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPINew.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string StudenName { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public int Age { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string CourseName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string BranchName { get; set; }
    }
}
