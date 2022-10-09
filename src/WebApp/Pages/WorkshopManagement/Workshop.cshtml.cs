using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class WorkshopModel : PageModel
{
    private readonly ILogger<WorkshopModel> _logger;

    public WorkshopModel(ILogger<WorkshopModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
      
    }
    [BindProperty]
    public List<WorkShop>? WorkShops { get; set; } = new List<WorkShop>
    {
        new WorkShop
        {
            Vehicle = "Jeep",
            Description = "4dr"
        }
    };
}
public class WorkShop
{

    public string Id { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string StartTime { get; set; } = string.Empty;
    public string EndTime { get; set; } = string.Empty;
    public string Vehicle { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
