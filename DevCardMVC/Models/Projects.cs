namespace DevCardMVC.Models
{
    public class Projects
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
    }

    public class Article
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class IndexModel
    {
        public List<Projects> Projects { get; set; }
        public List<Article> Articles { get; set; }
    }
}
