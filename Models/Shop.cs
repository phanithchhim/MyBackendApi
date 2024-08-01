namespace MyBackendApi.Models
{
    public class Shop
    {
        public  int Id {  get; set; }
        public  required string ShopName { get; set; }
        public required string ShopUrl { get; set;}
        public string? ShopDescription { get; set;}
        public string? ShopDescriptionurl { get;set;}
        public required string ShopAddress { get; set; }
        public required int  ShopPhone { get; set; }
        

    }
}
