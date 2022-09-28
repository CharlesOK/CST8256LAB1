using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab1.Pages;

public class IndexModel : PageModel
{
  private readonly ILogger<IndexModel> _logger;

  [BindProperty]
  public string FirstNumber { get; set; }
  [BindProperty]
  public string SecondNumber { get; set; }

  [BindProperty]
  public string ThirdNumber { get; set; }

  public IndexModel(ILogger<IndexModel> logger)
  {
    _logger = logger;
  }

  public void OnGet()
  {

  }

}
