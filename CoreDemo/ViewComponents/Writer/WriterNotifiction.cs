using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterNotifiction : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
