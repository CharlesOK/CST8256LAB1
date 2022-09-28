using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
// using System.Linq;
// using System.Collections.Generic;


namespace Lab1.Pages;

public class IndexModel : PageModel
{
  private readonly ILogger<IndexModel> _logger;

  [BindProperty]
  public string? FirstNumber { get; set; }
  [BindProperty]
  public string? SecondNumber { get; set; }

  [BindProperty]
  public string? ThirdNumber { get; set; }

  public string? ErrorMessage { get; set; }
  public string? Min { get; set; }

  public string? Max { get; set; }
  public string? Total { get; set; }

  public string? Average { get; set; }

  public int Count { get; set; }
  public bool Display { get; set; } = false;

  public IndexModel(ILogger<IndexModel> logger)
  {
    _logger = logger;
  }

  public void OnGet()
  {

  }

  public void OnPost()
  {

    var numbersList = new List<double>();

    double numbers;


    if (double.TryParse(FirstNumber, out numbers))
    {
      numbersList.Add(numbers);
    }


    if (double.TryParse(SecondNumber, out numbers))
    {
      numbersList.Add(numbers);
    }


    if (double.TryParse(ThirdNumber, out numbers))
    {
      numbersList.Add(numbers);
    }

    if (numbersList.Count == 0)
    {
      ErrorMessage = "You did not enter any number, no statistics were calculated!";
      return;
    }


    Count = numbersList.Count;
    Max = numbersList.Max().ToString("F2");
    Min = numbersList.Min().ToString("F2");
    Average = numbersList.Average().ToString("F2");
    Total = numbersList.Sum().ToString("F2");
    Display = true;




  }


}
