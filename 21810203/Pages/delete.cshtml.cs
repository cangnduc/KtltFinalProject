using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _21810203.Service;
using _21810203.Entities;

namespace _21810203.Pages
{
    public class deleteModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        [BindProperty(SupportsGet = true)]
        public string name { get; set; }
        List<Category> CuaHang = new List<Category>();
        public void OnGet()
        {
            CuaHang = ProductHandle.LoadingCH(CuaHang);
            CuaHang = ProductHandle.RemoveItem(CuaHang, name, Id);
            ProductHandle.SaveCH(CuaHang);
            Response.Redirect("index");

        }
        public void OnPost()
		{

		}
    }
}
