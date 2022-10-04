using Microsoft.AspNetCore.Mvc;
using _21810203.Entities;
using _21810203.Service;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _21810203.Pages
{
    public class EditModel : PageModel
    {
        public List<Category> CuaHang = new List<Category> ();
        public Product product = new Product();
        
       
        [BindProperty]
        public string? pname { get; set; }
        [BindProperty]
        public int pid { get; set; }
        [BindProperty]
        public double? Price { get; set; }
        [BindProperty]
        public string? Expiration { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public int id { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? name { get; set; }
       
        Product prod = new Product();
        public void OnGet()
        {
           
            
            CuaHang = ProductHandle.LoadingCH(CuaHang);
            foreach(var items in CuaHang)
            {
                if(items.name == name)
                {
                    foreach(var item in items.dsach)
                    {
                        if (item.id == id)
                        {
                            product = item;
                            /*product.id = item.id;
                            product.name = name;
                            product.price = double.Parse(Price);*/

                        }
                    }
                }
            }
        }
        public void OnPost()
        {
            CuaHang = ProductHandle.LoadingCH(CuaHang);
            string Catnames = Request.Form["Catnames"];
            if (pname != null & Price !=null & Expiration != null) {
                Console.WriteLine("aaaa");
                prod.id = pid;
                prod.name = pname;
                prod.Expiration = Expiration;
                prod.price = (double)Price;
            }
            
           
           
            Console.WriteLine($"id: {prod.id}, name: {prod.name}, {Catnames}");
            //Console.WriteLine(id,name,pname);
            CuaHang = ProductHandle.RemoveItem(CuaHang, name, id);
            if (Catnames != null)
            {
                CuaHang = ProductHandle.AddItem(CuaHang, prod, Catnames);
            }
           
            ProductHandle.SaveCH(CuaHang);
            Response.Redirect("Index");
        }
    }
}
