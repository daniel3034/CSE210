namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        private int Laps { get; }

        public Swimming(DateTime date, int lengthInMinutes, int laps)
            : base(date, lengthInMinutes)
        {
            Laps = laps;
        }

        public override double GetDistance()
        {
            return Laps * 50 / 1000.0 * 0.62; // Convert meters to miles
        }

        public override double GetSpeed()
        {
            return (GetDistance() / LengthInMinutes) * 60;
        }

        public override double GetPace()
        {
            return LengthInMinutes / GetDistance();
        }

        public override string GetSummary()
        {
            return $"{Date.ToShortDateString()} {GetType().Name} ({LengthInMinutes} min) - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile, Laps: {Laps}";
        }
    }
}
