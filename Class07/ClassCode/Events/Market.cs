using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Market
    {
        public string Name { get; set; }
        public ProductType ProductOnPromotion { get; set; }

        public delegate void PromotionSender(ProductType productType);
        public event PromotionSender Promotion;
        public void Subscribe(PromotionSender promotion)
        {
            Promotion += promotion;
        }
        public void Unsubscribe(PromotionSender promotion)
        {
            Promotion -= promotion;
        }
        public void SendPromotionInfo()
        {
            Console.WriteLine($"{Name}market is sending a promotion info for {ProductOnPromotion}");
            Promotion(ProductOnPromotion);
        }
    }
}
