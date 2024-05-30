using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public class Department
    {
        public Department()
        {
            Students=new HashSet<Student>();
            Subjects=new HashSet<DepartmentSubject>();
        }
        [Key]
        public int Id{ get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [InverseProperty("Departments")]
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<DepartmentSubject> Subjects { get; set; }

    }
}
