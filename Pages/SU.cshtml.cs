using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ParcelBusters.Pages;

public class SUModel : PageModel
{
    private readonly ILogger<SUModel> _logger;

    public SUModel(ILogger<SUModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}


