using Microsoft.AspNetCore.Mvc;
using _21810203.DAL;
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
        public List<Product> Products = new List<Product> { };
        public string chuoi = string.Empty;
        [BindProperty(SupportsGet =true)]
        public string CateList { get; set; }
        
        public void OnGet()
        {
            CuaHang = ProductSave.ReadingCate("Products.json", CuaHang);
        }
        public void OnPost()
        {
            foreach(Category cate in CuaHang)
            {
                if (cate.name == CateList)
                {
                    Products = cate.productList;
                }
            }
        }
    }
}