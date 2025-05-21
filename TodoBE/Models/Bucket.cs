using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TodoBE.Models
{
    public class Bucket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime createdAt { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
    }
}
