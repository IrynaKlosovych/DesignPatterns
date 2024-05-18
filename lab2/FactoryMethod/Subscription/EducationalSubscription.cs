
namespace lab2.FactoryMethod.Subscription
{
    public class EducationalSubscription : ISubscription
    {
        public double MonthlyFee { get; } = 5;

        public int MinSubscriptionPeriod { get; } = 2;

        public List<string> Channels { get; } = new List<string> { "Education Channel 1", "New Education", "Basic Channel" };
        public EducationalSubscription() { }

        void ISubscription.ToString()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine($"MonthlyFee: {MonthlyFee}\nMinSubscriptionPeriod: {MinSubscriptionPeriod}\nChannels:");
            foreach (var channel in Channels)
            {
                Console.WriteLine(channel);
            }
            Console.WriteLine("-------------------");
        }
    }
}
