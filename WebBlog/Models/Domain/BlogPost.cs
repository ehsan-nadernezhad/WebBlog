﻿namespace WebBlog.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }

        public string Heading { get; set; }

        public string PageTitle { get; set; }

        public string Content { get; set; }

        public string ShortDescription { get; set; }

        public string FeaturedImageUrl { get; set; }

        public string UrlHandle { get; set; }

        public DateTime PublisheDate { get; set; }

        public string Author { get; set; }

        public string Visible { get; set; }
    }
}
