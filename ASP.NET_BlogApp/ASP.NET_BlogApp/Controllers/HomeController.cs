using ASP.NET_BlogApp.Models;
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

        public bool IsAdmin
        {
            get
            {
                return User.IsInRole("Administrator");
            }
        }
        public ActionResult Index(int? id)
        {
            const int _postsPerPage = 4;
            int pageNumber = id ?? 0;
            IEnumerable<Post> posts =
                (from post in _model.Posts
                 where post.Date < DateTime.Now
                 orderby post.Date descending
                 select post).Skip(pageNumber * _postsPerPage).Take(_postsPerPage + 1);
            ViewBag.IsPreviousLinkVisible = pageNumber > 0;
            ViewBag.IsNextLinkVisible = posts.Count() > _postsPerPage;
            ViewBag.PageNumber = pageNumber;
            ViewBag.IsAdmin = IsAdmin;
            return View(posts.Take(_postsPerPage));
        }

        [ValidateInput(false)]
        public ActionResult UpdatePosts(int? id, string title, string body, DateTime date, string tags)
        {
            if (!IsAdmin)
            {
                return RedirectToAction("Index");
            }
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

            if (!id.HasValue)
            {
                _model.Posts.Add(post);
            }

            _model.SaveChanges();

            return RedirectToAction("Details", new { id = post.Id });
        }

        public ActionResult Edit (int? id)
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

        public ActionResult Details(int id)
        {
            Post post = GetPost(id);
            ViewBag.IsAdmin = IsAdmin;
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
            ViewBag.IsAdmin = IsAdmin;
            return View("Index", tag.Posts);
        }

        public ActionResult Delete(int id)
        {
            if (IsAdmin)
            {
                Post post = GetPost(id);
                _model.Posts.Remove(post);
                _model.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult DeleteComment(int id)
        {
            if (IsAdmin)
            {
                Comment comment = _model.Comments.Where(x => x.Id == id).First();
                _model.Comments.Remove(comment);
                _model.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult AdminPosts()
        {
            IEnumerable<Post> posts =
                from post in _model.Posts
                where post.Date < DateTime.Now
                orderby post.Date descending
                select post;
            return View(posts);
        }

        private Tag GetTagName(string tagName)
        {
            return _model.Tags.Where(x => x.Name == tagName).FirstOrDefault() ?? new Tag() { Name = tagName };
        }

        private Post GetPost(int? id)
        {
            return id.HasValue ? _model.Posts.Where(x => x.Id == id).First() : new Post() { Id = -1 };
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