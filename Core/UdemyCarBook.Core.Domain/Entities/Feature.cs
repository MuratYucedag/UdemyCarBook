using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Core.Domain.Entities
{
    public class Feature
    {
        public int FeatureID { get; set; }
        public string FeatureName { get; set; }
        public List<CarFeature> CarFeatures { get; set; }
    }
}
