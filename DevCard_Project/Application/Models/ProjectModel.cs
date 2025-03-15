using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Application.Models;

public class ProjectModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public string Url { get; set; }
}