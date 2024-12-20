﻿using Microsoft.EntityFrameworkCore;
using MyBlog.DataAccessLayer.Abstract;
using MyBlog.DataAccessLayer.Context;
using MyBlog.DataAccessLayer.Repositories;
using MyBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccessLayer.EntityFramework
{
    public class EfArticleDal : GenericRepository<Article>, IArticleDal
    {
        public EfArticleDal(BlogContext context) : base(context)
        {
        }

        public List<Article> ArticleListWithCategory()
        {
            var context = new BlogContext();
            var values =context.Articles.Include(x => x.Category).ToList();
            return values;
        }

        public List<Article> ArticleListWithCategoryAndAppUser()
        {
            var context = new BlogContext();
            var values=context.Articles.Include(x=>x.Category).Include(y=>y.AppUser).ToList();
            return values;
        }

        public Article ArticleListWithCategoryAndAppUserByArticleId(int id)
        {
            var context = new BlogContext();
            var values = context.Articles.Where(x => x.ArticleId == id).Include(y => y.Category).Include(z => z.AppUser).FirstOrDefault();
            return values;


        }

        public void ArticleViewCountIncrease(int id)
        {
            var context=new BlogContext();
            var updatedValue = context.Articles.Find(id);
            updatedValue.ArticleViewCount += 1;
            context.SaveChanges();


        }
    }
}
