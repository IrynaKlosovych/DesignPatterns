namespace lab2.FactoryMethod.Subscription
{
    public interface ISubscription
    {
        public double MonthlyFee { get; }
        public int MinSubscriptionPeriod { get; }
        public List<string> Channels { get; }
        public void ToString();
    }
}
