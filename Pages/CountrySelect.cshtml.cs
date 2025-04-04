using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class CountrySelectModel : PageModel
    {
        public List<string> Countries { get; set; } = new List<string>
        {
            "Danmark",
            "Tyskland",
            "Norge",
            "Sverige",
            "Nederlandene"
        };

        Filtering filtering = new Filtering();
        
        [BindProperty]
        public string? SearchString { get; set; }
        
        public void OnGet()
        {
        }

        public IActionResult OnPostNameSearch()
        {
            if (SearchString != null)
            {
                Countries = filtering.FilterList(Countries, SearchString);
            }
            
            return Page();
        }
    }
}
