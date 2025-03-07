namespace WebBlog.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string BlogPostId { get; set; }

    }
}
