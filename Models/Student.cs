using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace university.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Date of birth is required!")]
        public string DateOfBirth { get; set; }
        [Required(ErrorMessage = "Password is required!")]
        public string Password { get; set;}

        [Required(ErrorMessage = "Major is required!")]
        public int MajorId { get; set; }
        public Major Major { get; set; }

        public List<StudentCourse> Courses { get; set; }    
    }
}
