using System.ComponentModel.DataAnnotations;

namespace BookWeb_MVC_.Models
{
    public class Catagory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
