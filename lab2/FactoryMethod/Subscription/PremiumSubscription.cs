namespace lab2.FactoryMethod.Subscription
{
    public class PremiumSubscription: ISubscription
    {
        public double MonthlyFee { get; } = 35;

        public int MinSubscriptionPeriod { get; } = 1;

        public List<string> Channels { get; } = new List<string> { "Premium Channel", "New Prem", "Basic Channel" };
        public PremiumSubscription() { }

        void ISubscription.ToString()
        {
            Console.WriteLine($"MonthlyFee: {MonthlyFee}\nMinSubscriptionPeriod: {MinSubscriptionPeriod}\nChannels:");
            foreach( var channel in Channels )
            {
                Console.WriteLine( channel );
            }
        }
    }
}
