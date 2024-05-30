using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public class StudentSubject
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        [ForeignKey("StudentId")]
        public virtual  Student Students { get; set; }
        [ForeignKey("SubjectId")]
        public virtual  Subject Subjects { get; set; }
    }
}
