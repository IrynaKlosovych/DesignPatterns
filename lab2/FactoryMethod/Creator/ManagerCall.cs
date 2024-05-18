using lab2.FactoryMethod.Subscription;

namespace lab2.FactoryMethod.Creator
{
    public class ManagerCall : FactorySubscription
    {
        public ManagerCall() { }

        public override ISubscription BuySubscription()
        {
            Console.WriteLine("Do you like watch videos with family? I think, yes, because you've bought Domectic Subscription");
            return new DomesticSubscription();
        }
    }
}
