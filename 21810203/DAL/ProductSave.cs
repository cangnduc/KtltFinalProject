using _21810203.Entities;
using System.IO;
using Newtonsoft.Json;

namespace _21810203.DAL
{
    public class ProductSave
    {
        public static List<Category> ReadingCate (string path, List<Category>? products)
        {
            StreamReader reader = new StreamReader(path);
            string json = reader.ReadToEnd();
            reader.Close();
            products = JsonConvert.DeserializeObject<List<Category>>(json);
            if (products != null)
            {
                return products;
            }
            return new List<Category> ();
        }
        public static void SaveCH (List<Category> Cuahang, string path)
        {
            /*string products = "";
            if(Cuahang.Count > 0)
            {
                products = JsonConvert.SerializeObject(Cuahang);
                
            }
            */
            
            string products = JsonConvert.SerializeObject(Cuahang);
            
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(products);
            writer.Close();
        }
    }

}
