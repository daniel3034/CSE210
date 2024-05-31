namespace ExerciseTracking
{
    public class Cycling : Activity
    {
        private double Speed { get; }

        public Cycling(DateTime date, int lengthInMinutes, double speed)
            : base(date, lengthInMinutes)
        {
            Speed = speed;
        }

        public override double GetDistance()
        {
            return (Speed * LengthInMinutes) / 60;
        }

        public override double GetSpeed()
        {
            return Speed;
        }

        public override double GetPace()
        {
            return 60 / Speed;
        }
    }
}
