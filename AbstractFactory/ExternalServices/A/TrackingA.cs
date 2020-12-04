namespace AbstractFactory
{
    internal class TrackingA : ITracking
    {
        public string GetTracking()
        {
            return "The result of the TrackingA.";
        }
    }
}