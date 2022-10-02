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
            products = JsonConvert.DeserializeObject<List<Category>>(json);
            if (products != null)
            {
                return products;
            }
            return new List<Category> ();
        }
    }

}
