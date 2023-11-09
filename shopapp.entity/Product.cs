namespace shopapp.entity
{

    public class Product
    {
         public  string Name { get; set; }
         public string Description { get; set; }
         public  double Price { get; set; }
          public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
         public int ProductID { get; set; }
          public List<ProductCategory> ProductCategory { get; set; }
    }
}