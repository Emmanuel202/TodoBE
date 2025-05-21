namespace TodoBE.Models
{
    public class Bucket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime createdAt { get; set; }
        public int UserId { get; set; }
    }
}
