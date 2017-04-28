﻿using ASP.NET_BlogApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ASP.NET_BlogApp.Controllers
{
    public class HomeController : Controller
    {
        private BlogModel _model = new BlogModel();

        public ActionResult Index(int? id)
        {
            const int postsPerPage = 4;
            int pageNumber = id ?? 0;
            IEnumerable<Post> posts = _model.Posts
                .Where(post => post.Date < DateTime.Now)
                .OrderByDescending(post => post.Date)
                .Select(post => post)
                .Skip(pageNumber * postsPerPage)
                .Take(postsPerPage + 1);

            ViewBag.IsPreviousLinkVisible = pageNumber > 0;
            ViewBag.IsNextLinkVisible = posts.Count() > postsPerPage;
            ViewBag.PageNumber = pageNumber;
            return View(posts.Take(postsPerPage));
        }

        [ValidateInput(false)]
        [Authorize(Roles = "Administrator")]
        public ActionResult UpdatePosts(int id, string title, string body, DateTime date, string tags)
        {
            Post post = GetPost(id);
            post.Title = title;
            post.Body = body;
            post.Date = date;
            post.Tags.Clear();

            tags = tags ?? string.Empty;
            List<string> tagNames = tags.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (string tagName in tagNames)
            {
                post.Tags.Add(GetTagName(tagName));
            }

            _model.SaveChanges();

            return RedirectToAction("AdminPosts");
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult CreatePost (string title, string body, DateTime? date, string tags)
        {
            if (string.IsNullOrEmpty(title) && string.IsNullOrEmpty(body) && !date.HasValue && string.IsNullOrEmpty(tags))
            {
                return View();
            }
            Post post = new Post();
            post.Title = title;
            post.Body = body;
            post.Date = (DateTime)date;

            post.Tags.Clear();
            List<string> tagNames = tags.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (string tagName in tagNames)
            {
                post.Tags.Add(_model.Tags.Where(x => x.Name == tagName).FirstOrDefault() ?? new Tag() { Name = tagName });
            }
            
            _model.Posts.Add(post);
            _model.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult EditPost (int id)
        {
            Post post = GetPost(id);
            StringBuilder taglist = new StringBuilder();

            foreach (Tag tag in post.Tags)
            {
                taglist.AppendFormat($"{tag.Name} ");
            }

            ViewBag.Tags = taglist.ToString();

            return View(post);
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult AdminView(IndexViewModel model)
        {
            return View(model);
        }

        public ActionResult Details(int id)
        {
            Post post = GetPost(id);
            return View(post);
        }

        [ValidateInput(false)]
        public ActionResult Comment(int id, string name, string email, string body)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(body))
            {
                Post post = GetPost(id);
                Comment comment = new Comment();
                comment.Post = post;
                comment.Date = DateTime.Now;
                comment.Name = name;
                comment.Email = email;
                comment.Body = body;
                _model.Comments.Add(comment);
                _model.SaveChanges();
            }

            return RedirectToAction("ShowComments", new { id = id });
        }

        public ActionResult ShowComments(int id)
        {
            Post post = GetPost(id);
            return PartialView(post);
        }

        public ActionResult Tags(string id)
        {
            Tag tag = GetTagName(id);
            return View("Index", tag.Posts);
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult DeletePost(int id)
        {
            Post post = GetPost(id);
            _model.Posts.Remove(post);
            _model.SaveChanges();

            return RedirectToAction("AdminPosts");
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult DeleteComment(int id)
        {
            Comment comment = _model.Comments.Where(x => x.Id == id).First();
            _model.Comments.Remove(comment);
            _model.SaveChanges();

            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult AdminPosts()
        {
            IEnumerable<Post> posts = _model.Posts
                .Where(post => post.Date < DateTime.Now)
                .OrderByDescending(post => post.Date)
                .Select(post => post);

            return View(posts);
        }

        private Tag GetTagName(string tagName)
        {
            return _model.Tags.Where(x => x.Name == tagName).FirstOrDefault();
        }

        private Post GetPost(int id)
        {
            return _model.Posts.Where(x => x.Id == id).First();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}