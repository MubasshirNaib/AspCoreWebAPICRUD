using System.ComponentModel.DataAnnotations;

namespace AspCoreWebAPICRUD.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
    }
}
