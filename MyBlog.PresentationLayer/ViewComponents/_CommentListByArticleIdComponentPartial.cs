using Microsoft.AspNetCore.Mvc;
using MyBlog.BusinessLayer.Abstract;

namespace MyBlog.PresentationLayer.ViewComponents
{
    public class _CommentListByArticleIdComponentPartial:ViewComponent
    {
        private readonly ICommentService _commentService;
        public _CommentListByArticleIdComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;   
        }
        public IViewComponentResult Invoke()
        {
            var values = _commentService.TGetCommentsByArticleId(7);
            return View(values);
        }
    }
}
