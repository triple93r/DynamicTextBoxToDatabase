namespace WebApplication1.Models
{
    public class tbl_Subject
    {
        public int Id { get; set; }
        public string sName { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public decimal Price { get; set; } = decimal.Zero;
        public string grade { get; set; } = string.Empty;
    }
}
