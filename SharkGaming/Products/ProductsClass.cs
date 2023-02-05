using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SharkGaming.Products
{
    public class ProductsClass
    {           
        protected static int nextId = 0;     
        public int Id { get; set; }

        [Display(Name = "Item Navn")]
        [Required(ErrorMessage = "Item skal have et navn"), MaxLength(500)]
        public string Name { get; set; }

        [Display(Name = "Pris")]
        [Required(ErrorMessage = "Der skal angives en pris")]
        [Range(typeof(double), "0", "10000", ErrorMessage = "Prisen skal være mellem {1} og {2}")]
        public double? Price { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }

        public ProductsClass(string name, double price, string img, string description, string link)
        {
            Price = price;
            Name = name;
            Img = img;
            Description = description;
            Link = link;
        }

        public ProductsClass()
        {

        }


        

    }
}
