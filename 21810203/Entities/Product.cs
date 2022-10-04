namespace _21810203.Entities
{
    public struct Product
    {
        public int id;
        public string name;
        public double price;
        public string Expiration;
        //public Category LoaiHang;
    }
    public struct Category
    {
        public string name;
        public List<Product> dsach;
   }

}
