using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IBAS_menu.Pages;

public class KantineModel : PageModel
{
    private readonly ILogger<KantineModel> _logger;

    public KantineModel(ILogger<KantineModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
