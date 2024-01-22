using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class StudentClass
    {
        [Key]
        public int Id { get; set; }
        public int StudId { get; set; }
        public int ClassId { get; set; }

        [NotMapped]
        public string ClassName { get; set; }
        [NotMapped]
        public int sel1 { get; set; }
    }
}
