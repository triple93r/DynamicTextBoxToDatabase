using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class stdVM
    {
        public int Id {  get; set; }
        public int ClassId { get; set; }
        public string Notes { get; set; }
        [NotMapped]
        public List<tblStudent> Students { get; set; }
    }
}
