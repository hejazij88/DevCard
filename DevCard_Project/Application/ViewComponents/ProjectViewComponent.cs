using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace Application.ViewComponents;

public class ProjectViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View("_Project");
    }
    
}