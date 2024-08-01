using System.ComponentModel.DataAnnotations;

namespace MyBackendApi.Models
{
    public class Customer
    {
        public  int Id { get; set; } 
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }
        public required string Url { get; set; }
        public required int PhoneNumber { get; set; }
       


}
}
