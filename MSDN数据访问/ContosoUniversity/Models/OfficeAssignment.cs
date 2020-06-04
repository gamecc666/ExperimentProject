using System.ComponentModel.DataAnnotaions;
using System.ComponentModel.DataAnnotaions.Schema;

namespace ContosoUniversity
{
	public class OfficeAssignment{
		[Key]
		public int InstructorID{get;set;}    //该主键也是Instructor实体的外键
		
		[StringLength(50)]
		[Display(Name="Office Location")]
		public string Location{get;set;}
		
		public Instructor{get;set;}
	}
}