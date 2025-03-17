using Application.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace Application.ViewComponents;

public class ProjectViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {   
        return View("_Project",new List<ProjectModel>
        {
            new ProjectModel{Id = new Guid(),Name = "DevCard",Url = "https://github.com/hejazij88/DevCard",Description = "The Portfolio And Don't Use DataBase , Use View Component And Static Data",Image = "PortFolio.jpg"},
            new ProjectModel{Id = new Guid(),Name = "BlazorChatRoom",Url = "https://github.com/hejazij88/BlazorChatRoom",Description = "The Chat Room By Blazor ",Image = "ChatRoom.png"},
            new ProjectModel{Id = new Guid(),Name = "TorontoShop",Url = "https://github.com/hejazij88/TorontoShop",Description = "The Online Shop by Asp.net Core ",Image = "OnlineShop.jpg"},
            new ProjectModel{Id = new Guid(),Name = "Virgol",Url = "https://github.com/hejazij88/Virgol",Description = "The Online Article Web Site by Asp.net MVC ",Image = "Virgol.jpg"},
        });
    }
    
}