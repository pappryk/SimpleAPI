using System.ComponentModel.DataAnnotations;

namespace EquinityExercise.Models
{
    public class HiringManager
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
