using Microsoft.AspNetCore.Mvc;
using _21810203.Entities;
using _21810203.Service;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _21810203.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public List<Category> CuaHang = new List<Category> { };
        
        public string chuoi = string.Empty;
        [BindProperty(SupportsGet =true)]
        public string CateList { get; set; }
        
        public void OnGet()
        {
            CuaHang = ProductHandle.LoadingCH(CuaHang);
        }
        public void OnPost()
        {
           
        }
    }
}