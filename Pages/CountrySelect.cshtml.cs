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
        
        public void OnGet()
        {
        }
    }
}
