using Microsoft.AspNetCore.Mvc;

namespace Application.ViewComponents;

public class ArticleViewComponent:ViewComponent
{

    public IViewComponentResult Invoke()
    {
        return View("_Article");
    }
}