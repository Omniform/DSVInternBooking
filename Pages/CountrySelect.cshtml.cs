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

        public string m_country;
        
        public void OnGet()
        {
        }

        public void OnPost(string country)
        {

        }
    }
}
