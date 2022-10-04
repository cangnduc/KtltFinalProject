using _21810203.Entities;
using _21810203.DAL;
namespace _21810203.Service
{
    public class ProductHandle
    {
        public static List<Category> LoadingCH (List<Category> CuaHang)
        {
            CuaHang = ProductSave.ReadingCate("Products.json", CuaHang); 
            if(CuaHang.Count>0)
            {
                return CuaHang;
            }
            return new List<Category> ();
        }
        public static List<Category> FindCH (List<Category> CuaHang, string CateName = "All", string ProductName="")
        {
            List<Category> list = new List<Category>();
            foreach(var items in CuaHang)
            {
                if(CateName == "All")
                {
                    list = CuaHang;
                }
                else if (items.name == CateName)
                {
                    list.Add(items);
                }
            }
            if(list.Count > 0)
            {
                return list;
            }
            return new List<Category> ();
        }

        public static void SaveCH(List<Category> CuaHang)
        {
            string path = "Products.json";
            ProductSave.SaveCH(CuaHang, path);
        }
        public static List<Category> RemoveItem(List<Category> CuaHang,string CateNam,int id)
        {
            foreach(var items in CuaHang)
            {
                if(items.name == CateNam)
                {
                    items.dsach.RemoveAll(r => r.id == id);
                }
            }
            return CuaHang;
        }
        public static List<Category> AddItem(List<Category> CuaHang, Product prod, string CateName)
        {
            foreach(var items in CuaHang)
            {
                if(items.name == CateName)
                {
                    items.dsach.Add(prod);
                    return CuaHang;
                }
            }
            return CuaHang;
        }
        public static int FindUniqueID(List<Category> CuaHang,string Catname)
		{
            int id = 0;
            foreach(var items in CuaHang)
			{
                if (items.name == Catname)
				{
                    foreach(var item in items.dsach)
					{
                        
                        if(id <item.id)
						{
                            id = item.id;
						}
					}
				}
			}
            return id+1;
		}
    }
}
