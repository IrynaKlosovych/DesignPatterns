using lab2.FactoryMethod.Subscription;

namespace lab2.FactoryMethod.Creator
{
    public class WebSite : FactorySubscription
    {
        public WebSite() { }
        public override ISubscription BuySubscription()
        {
            Console.WriteLine("Some code for website.\nFor example it returns Premium Subscription," +
                " because I'm really lazy to think about another code");
            return new PremiumSubscription();
        }
    }
}
