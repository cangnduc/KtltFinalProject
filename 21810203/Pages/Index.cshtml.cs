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
        public List<Category> CuaHang = new List<Category> ();
        
        /*[BindProperty(SupportsGet =true)]
        public string ProductName { get; set; }
        
        [BindProperty(SupportsGet =true)]
        public string CateName { get; set; }*/
        
        public void OnGet()
        {
            CuaHang = ProductHandle.LoadingCH(CuaHang);
            //CuaHang = ProductHandle.FindCH(CuaHang, "All", ProductName);
           

        }
        public void OnPost()
        {
           
            //CuaHang = ProductHandle.FindCH(CuaHang, CateName, ProductName);
        }
    }
}