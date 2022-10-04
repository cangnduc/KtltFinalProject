using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _21810203.Entities;
using _21810203.Service;
namespace _21810203.Pages
{
    public class AddProductModel : PageModel
    {
        
        [BindProperty]
        public string? Name { get; set; }
        [BindProperty]
        public string? Expiration { get; set; }
        [BindProperty]
        public double ? Price { get; set; }
        public string Catname = String.Empty;
        public List<Category> CuaHang = new List<Category>();
        public int ids = 0;
        public void OnGet()
        {
            CuaHang = ProductHandle.LoadingCH(CuaHang);


        }
        public string loi = string.Empty;
        public void OnPost()
		{
            CuaHang = ProductHandle.LoadingCH(CuaHang);
            Product prod = new Product();
            Catname = Request.Form["Catname"];
            try
			{
                if (Name != null & Price!= null & Expiration != null)
				{
                    ids = ProductHandle.FindUniqueID(CuaHang, Catname);
                    prod.id = ids;
                    prod.name = Name;
                    prod.price = (double)Price;
                    prod.Expiration = Expiration;
                    Console.WriteLine("aaa");
                    
                }
                
                Console.WriteLine(Catname);
                CuaHang = ProductHandle.AddItem(CuaHang, prod, Catname);
                ProductHandle.SaveCH(CuaHang);
                
            }
            catch (Exception ex)
			{
                loi = ex.Message;
			}
            Response.Redirect("Index");


		}
    }
}
