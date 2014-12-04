
using Magicodes.Models.Blog.Models.Account;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Magicodes.Models.Blog.Models.Post;

namespace Magicodes.Models.Blog.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<BlogDbContext>
    {
        public Configuration()
        {
            //�ر��Զ�����Ǩ�ƣ��ó���ֻ�������Լ����ɵ�Ǩ�ƣ�
            AutomaticMigrationsEnabled = false;
            //AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BlogDbContext context)
        {
            var blogUser = new BlogUser {Id = "{B0FBB2AC-3174-4E5A-B772-98CF776BD4B9}"};
            var user = context.User.FirstOrDefault(m => m.Id == blogUser.Id);
            if (user!=null)
                blogUser = user;
            else
            context.User.Add(blogUser);
                context.SaveChanges();   
            var subjectList = new List<SubjectCategory> 
            {
                new SubjectCategory 
                { 
                   Title="ר������_Test",Description="ר������_Test"
                }
            };
           context.SubjectCategory.AddOrUpdate(l => l.Title, subjectList.ToArray());
           var blogTag = new BlogTag
            {
                Name = "��ǩ_Test"
            };
           var tag = context.BlogTag.FirstOrDefault(m => m.Name == "��ǩ_Test");
            if (tag != null)
                // ReSharper disable once RedundantAssignment
                blogTag = tag;
            else
                context.BlogTag.Add(blogTag);
            context.SaveChanges();
            var blogPost = new BlogPost
            {
                Sender = blogUser,
                Title = "���ͱ���_Test",
                Content = "<h1>��������_Test<h2>",
            };
            var post = context.BlogPost.FirstOrDefault(m => m.Title == blogPost.Title);
            if (post!=null)
                blogPost = post;
            else
                context.BlogPost.Add(blogPost);
            context.SaveChanges();

            var blogPostSubject =  new BlogPostSubject {Post = blogPost, Subject = subjectList[0]};
            var postSubject = context.BlogPostSubject.FirstOrDefault(m => m.PostId == blogPost.Id);
            if (postSubject!=null)
                // ReSharper disable once RedundantAssignment
                blogPostSubject = postSubject;
            else
              context.BlogPostSubject.Add(blogPostSubject);
            context.SaveChanges();
        }
    }
}
