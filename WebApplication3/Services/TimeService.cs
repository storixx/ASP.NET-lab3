namespace WebApplication3.Services
{
    public class TimeService
    {
        public string GetTimeOfDay()
        {
            var hour = DateTime.Now.Hour;
            if (hour >= 6 && hour < 12) return "it's morning";
            if (hour >= 12 && hour < 18) return "it's daytime";
            if (hour >= 18 || hour < 0) return "it's evening";
            return "it's night";
        }
    }
}