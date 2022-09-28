using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab1.Pages;

public class IndexModel : PageModel
{
  private readonly ILogger<IndexModel> _logger;

  [BindProperty]
  public double FirstNumber { get; set; }
  [BindProperty]
  public double SecondNumber { get; set; }

  [BindProperty]
  public double ThirdNumber { get; set; }

  public IndexModel(ILogger<IndexModel> logger)
  {
    _logger = logger;
  }

  public void OnGet()
  {

  }

}
