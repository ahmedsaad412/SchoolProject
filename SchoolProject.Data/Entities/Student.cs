using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Address { get; set; }
        [StringLength(200)]
        public string Phone { get; set; }
        
        public int? DeptId { get; set; }
        [ForeignKey("DeptId")]
        [InverseProperty("Students")]
        public virtual Department Departments{ get; set; }
        public virtual ICollection<StudentSubject> Subjects{ get; set; }


    }
}
