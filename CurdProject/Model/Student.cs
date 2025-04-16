using System.ComponentModel.DataAnnotations;

namespace CurdProject.Model
{
    public class Student   //Property or Model or Entity
    {
        [Key]
        public int Id { get; set; } //Primary Key 
        [Required]
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public int PhoneNo { get; set; }    

    }
}
