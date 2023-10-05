using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Core.Domain.Entities
{
    public class Car
    {
        public int CarID { get; set; }
        public int BrandID { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string ImageUrl { get; set; }
        public int Km { get; set; }
        public string Transmission { get; set; }
        public string Seat { get; set; }
        public string Luggage { get; set; }
        public string Fuel { get; set; }
        public List<CarDescription> CarDescriptions { get; set; }
        public List<CarFeature> CarFeatures { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Pricing> Pricings { get; set; }
    }
}
