using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class User
    {
        public string Name { get; set; } = string.Empty;

        public ProductType FavoriteProductType { get; set; }

        public void ReactOnPromotion(ProductType productType)
        {
            if(productType == FavoriteProductType)
            {
                Console.WriteLine("It's my favorite product");
            }
            else
            {
                Console.WriteLine($"{Name} hates this {productType.ToString()}");
            }
        }
    }
}
