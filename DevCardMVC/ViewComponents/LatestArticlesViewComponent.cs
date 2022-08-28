using DevCardMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCardMVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Article> articles;
            articles = new List<Article>
            {
                new Article(1, "اموزش Asp.net core mvc", "بهترین آموزش asp.net core mvc", "blog-post-thumb-card-1.jpg"),
                new Article(2, "اموزش Git & GitHub", "بهترین آموزش Git & GitHub", "blog-post-thumb-card-2.jpg"),
                new Article(3, "اموزش طراحی سایت", "بهترین آموزش طراحی سایت", "blog-post-thumb-card-3.jpg"),
                new Article(4, "اموزش طراحی اندروید", "بهترین آموزش طراحی اندروید", "blog-post-thumb-card-4.jpg"),
                new Article(5, "اموزش بلاکچین", "بهترین آموزش بلاکچین", "blog-post-thumb-card-5.jpg"),
            };
            return View("_LatestArticles", articles);
        }

    }
}
