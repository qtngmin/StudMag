using System.ComponentModel.DataAnnotations;

namespace StudMag.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int ZipCode { get; set; }
    }
}
