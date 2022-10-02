using Microsoft.AspNetCore.Mvc;
using _21810203.Entities;
using _21810203.DAL;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _21810203.Pages
{
    public class EditModel : PageModel
    {
        public List<Category> CuaHang = new List<Category> { };
        public Product product = new Product();
        public int test = 0;
       [BindProperty(SupportsGet = true)]
        public string name { get; set; }
        [BindProperty(SupportsGet = true)]
        public int id { get; set; }

        public void OnGet()
        {
            
            CuaHang = ProductSave.ReadingCate("Products.json", CuaHang);
            foreach(var items in CuaHang)
            {
                if(items.name == name)
                {
                    foreach(var item in items.dsach)
                    {
                        if (item.id == id)
                        {
                            product = item;

                        }
                    }
                }
            }
        }
        public void OnPost()
        {

        }
    }
}
