using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoAn_Lab.Models;
using DoAn_Lab.ViewModels;

namespace DoAn_Lab.Controllers
{
    public class HomeController : Controller
    {
        IList<Blog> Blogs = new List<Blog>();
        public HomeController()
        {
            Blogs.Add(
                new Blog
                {
                    Id = 1,
                    Title = "8 Inspiring Ways to Wear Dresses in the Winter",
                    Image = "/images/blog-01.jpg",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis aliquet luctus nisl, et pharetra elit rhoncus eget. Fusce commodo tortor at posuere ullamcorper. Sed sagittis nec sem id consequat. Proin nisi lorem, gravida vel nunc eget, condimentum cursus leo. Pellentesque gravida tellus eu lectus tincidunt, in pellentesque enim dictum. Suspendisse condimentum porttitor tincidunt. Cras iaculis at magna at elementum. Vestibulum varius finibus quam at luctus. Fusce ligula eros, sollicitudin vel mauris non, hendrerit dignissim diam. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus."
                });

            Blogs.Add(
                new Blog
                {
                    Id = 2,
                    Title = "The Great Big List of Men’s Gifts for the Holidays",
                    Image = "/images/blog-02.jpg",
                    Description = "Nulla eleifend leo posuere ex vulputate sodales. Vivamus placerat consectetur felis, id sodales nisl scelerisque sed. Proin at accumsan justo. Suspendisse ultrices iaculis ultricies. Praesent sollicitudin, risus vitae bibendum tempor, sem nulla luctus mi, eu euismod ipsum tellus eget est. Cras orci odio, semper sit amet arcu ut, viverra elementum mauris. Curabitur congue egestas dui, eu sodales sapien scelerisque vel. Donec eget velit non ipsum facilisis commodo quis sed sapien."
                });

            Blogs.Add(
                new Blog
                {
                    Id = 3,
                    Title = "5 Winter-to-Spring Fashion Trends to Try Now",
                    Image = "/images/blog-03.jpg",
                    Description = "In gravida nisi consectetur dolor sollicitudin, quis pharetra massa luctus. Nam aliquam dui vel bibendum consequat. Curabitur congue, erat at tincidunt porta, augue urna aliquet lectus, quis ornare dui nisl quis ipsum. Curabitur convallis justo sed leo feugiat faucibus. Quisque ac elit leo. Sed finibus odio nec urna sagittis mollis. Donec massa elit, molestie quis eros at, luctus sodales nulla. Phasellus pretium mattis lacinia. Aenean ornare, ante non semper ultrices, velit nisi maximus nulla, sed blandit massa enim eget lectus. Aenean eget finibus mauris. Suspendisse vitae tempor arcu."
                });

            Blogs.Add(
                new Blog
                {
                    Id = 4,
                    Title = "5 Winter-to-Spring Fashion Trends to Try Now",
                    Image = "/images/blog-02.jpg",
                    Description = "Nunc venenatis, nulla nec posuere condimentum, urna elit euismod metus, vitae placerat nulla sapien vitae tortor. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Cras tellus mi, consectetur vitae tellus ut, porttitor rutrum dui. Nunc sit amet turpis justo. Integer eget mauris nisl. Etiam nunc dolor, accumsan vitae egestas ac, porta ac turpis. Phasellus cursus euismod leo, eget iaculis elit commodo vitae."
                });

            Blogs.Add(
                new Blog
                {
                    Id = 5,
                    Title = "The Great Big List of Men’s Gifts for the Holidays",
                    Image = "/images/blog-03.jpg",
                    Description = "Duis lobortis, augue eget bibendum commodo, sem lacus vehicula magna, et luctus erat odio vitae est. Donec maximus enim id justo posuere, ut porttitor leo vestibulum. Maecenas id diam tempor, varius ligula sit amet, ultrices nisi. Vivamus sagittis enim augue, eget pellentesque leo efficitur eget. Sed elementum varius augue a malesuada. Duis pellentesque luctus dui sit amet porta. Proin dignissim nisl justo, eget condimentum libero eleifend a. Quisque nec tristique ex. Proin sodales eros quis eros varius pharetra."
                });

            Blogs.Add(
               new Blog
               {
                   Id = 6,
                   Title = "Make your crush love you",
                   Image = "/images/blog-01.jpg",
                   Description = "Duis lobortis, augue eget bibendum commodo, sem lacus vehicula magna, et luctus erat odio vitae est. Donec maximus enim id justo posuere, ut porttitor leo vestibulum. Maecenas id diam tempor, varius ligula sit amet, ultrices nisi. Vivamus sagittis enim augue, eget pellentesque leo efficitur eget. Sed elementum varius augue a malesuada. Duis pellentesque luctus dui sit amet porta."
               });
        }
        public IActionResult Index()
        {
            ViewBag.blogsList = Blogs;
            return View();
        }


        public IActionResult IndexGrid()
        {
            ViewData["blogsList"] = Blogs;
            return View();
        }

        public IActionResult IndexStaggered()
        {
            return View(Blogs);
        }

        public IActionResult IndexSlider()
        {
            BlogViewModel model = new BlogViewModel()
            {
                ListBlogs = Blogs
            };
            return View(model);
        }
    }
}
