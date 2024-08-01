namespace MyBackendApi.Models
{
    public class Dilevery
    {
        public int Id { get; set; }
        public required List<Shop> Infor { get; set; }
        public required List<Order> Orders { get; set; }
        public required string Username { get; set; }
        public required int PhoneNumber { get; set; }
        public int Age { get; set; }
        public int Total { get; set; }
        public required int CustomerId { get; set; }

      
    }
}
