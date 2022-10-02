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
            return new List<Category> { };
        }
    }
}
