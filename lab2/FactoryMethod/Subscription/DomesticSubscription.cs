namespace lab2.FactoryMethod.Subscription
{
    public class DomesticSubscription: ISubscription
    {
        public double MonthlyFee { get;  } = 10;
        public int MinSubscriptionPeriod { get; } = 1;
        public List<string> Channels { get; } = new List<string> { "Local Channels", "Basic Channels" };
        public DomesticSubscription() { }

        void ISubscription.ToString()
        {
            Console.WriteLine($"Channels:");
            foreach (var channel in Channels)
            {
                Console.WriteLine(channel);
            }
        }
    }
}
