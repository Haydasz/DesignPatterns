namespace AbstractFactory
{
    internal class TrackingB : ITracking
    {
        public string GetTracking()
        {
            return "The result of the TrackingB.";
        }
    }
}