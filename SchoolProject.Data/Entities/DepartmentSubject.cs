using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public class DepartmentSubject
    {
        [Key]
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int SubjectId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Departments { get; set; }
        [ForeignKey("SubjectId")]
        public virtual Subject Subjects { get; set; }
    }
}
