using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _21810203.Pages
{
    public class AddCategoryModel : PageModel
    {
        public string chuoi = string.Empty;
        [BindProperty]
        public string? categoryName { get; set; }
        [BindProperty]
        public string? categoryPrice { get; set; }
        public void OnGet()
        {
            string chuoi = string.Empty;
        }
        public void OnPost()
        {
            chuoi = "tess";
            Response.Redirect("/index");
        }
    }
}
