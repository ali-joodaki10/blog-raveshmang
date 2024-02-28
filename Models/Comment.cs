namespace BlogApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Blog Blog { get; set; }
        public int BlogId { get; set; }
    }
}
