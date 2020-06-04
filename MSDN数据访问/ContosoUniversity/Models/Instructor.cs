using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Instructor
    {
        public int ID { get; set; }
		
		[Required]
		[Display(Name="Last Name")]
		[StringLength(50)]
        public string LastName { get; set; }
		
		[Required]	
		[Column("FirstName")]
		[Display(Name="First Name")]
		[StringLength(50)]
        public string FirstMidName { get; set; } 
		
		[DataType(DataType.Date)]
		[DisFormat(DateFormatString="0:{yyyy-MM-dd}",ApplyFormatInEditMode=true)]
		[Display(Name="Hire Date")]
		public DateTime HireDate{get;set;}
		
		[Display(Name="Full Name")]
		public string FullName
		{
			get{
				return LastName+","+FirstMidName;
			}
		}
		
		//一名讲师可以教授任意数量的课
        public ICollection<CourseAssignment> CourseAssignments{get;set;}
		
		//讲师最多只有一个办公室因此 拥有一个OfficeAssignment实体
		public OfficeAssignment OfficeAssignment{get;set;}
    }
}
























