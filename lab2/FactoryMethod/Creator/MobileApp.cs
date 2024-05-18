using lab2.FactoryMethod.Subscription;

namespace lab2.FactoryMethod.Creator
{
    public class MobileApp : FactorySubscription
    {
        public MobileApp() { }

        public override ISubscription BuySubscription()
        {
            Console.WriteLine("You have bought Educational Subscription by Mobile App");
            return new EducationalSubscription();
        }
    }
}
