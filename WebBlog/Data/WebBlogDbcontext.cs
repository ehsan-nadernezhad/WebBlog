﻿using Microsoft.EntityFrameworkCore;
using WebBlog.Models.Domain;

namespace WebBlog.Data
{
    public class WebBlogDbcontext : DbContext
    {
        public WebBlogDbcontext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }
}
