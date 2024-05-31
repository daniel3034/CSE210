namespace ExerciseTracking
{
    public abstract class Activity
    {
        protected DateTime Date { get; }
        protected int LengthInMinutes { get; }

        protected Activity(DateTime date, int lengthInMinutes)
        {
            Date = date;
            LengthInMinutes = lengthInMinutes;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{Date.ToShortDateString()} {GetType().Name} ({LengthInMinutes} min) - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
        }
    }
}
