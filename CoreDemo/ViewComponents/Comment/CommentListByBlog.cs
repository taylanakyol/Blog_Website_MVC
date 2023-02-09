using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {

            CommentManager cm = new CommentManager(new EfCommentRepository());
            var values = cm.GetList(id);
            return View(values);

        }

    }
}
