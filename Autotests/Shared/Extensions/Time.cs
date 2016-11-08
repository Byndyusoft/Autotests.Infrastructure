namespace Shared.Extensions
{
    public class Time
    {
        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        private int Hours { get; }
        private int Minutes { get; }

        public override string ToString()
        {
            return $"{Hours:00}:{Minutes:00}";
        }
    }
}