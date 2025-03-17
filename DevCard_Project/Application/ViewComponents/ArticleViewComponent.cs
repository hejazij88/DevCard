using Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Application.ViewComponents;

public class ArticleViewComponent:ViewComponent
{

    public IViewComponentResult Invoke()
    {
        return View("_Article",new List<ArticleModel>
        {
            new ArticleModel{Id = new Guid(),Name = "Docker Essentials",Url = "https://www.linkedin.com/pulse/docker-essentials-mohammad-javad-hejazi-g7mif/?trackingId=E336Avk7oF43yrCv0JOYnA%3D%3D",Description = "Docker: An open-source platform that automates the deployment, scaling, and management of applications in lightweight containers. It allows developers to package applications with all dependencies into a standardized unit,...",Image = "Docker.png"},
            new ArticleModel{Id = new Guid(),Name = " Railway Oriented Programming",Url = "https://www.linkedin.com/posts/mohammad-javad-hejazi-749302247_programming-functionalprogramming-errorhandling-activity-7185525169694662657-TYml?utm_source=share&utm_medium=member_desktop&rcm=ACoAAD0XZakBg9mOnWVP6oqJWnw1n7pJwd2KU6Q",Description = "Have you heard of Railway Oriented Programming (ROP)?",Image = "Railway Oriented Programming.png"},
            new ArticleModel{Id = new Guid(),Name = " CLR",Url = "https://www.linkedin.com/posts/mohammad-javad-hejazi-749302247_dotnet-csharp-clr-activity-7179719600740155392-BRaW?utm_source=share&utm_medium=member_desktop&rcm=ACoAAD0XZakBg9mOnWVP6oqJWnw1n7pJwd2KU6Q",Description = "Excited to share insights on the core components of the .NET framework",Image = "CLR.png"},

            
        });
    }
}