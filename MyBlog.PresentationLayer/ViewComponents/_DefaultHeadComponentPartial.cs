using Microsoft.AspNetCore.Mvc;

namespace MyBlog.PresentationLayer.ViewComponents
{
    public class _DefaultHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
