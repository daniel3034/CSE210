namespace EventPlanning
{
    public class Lecture : Event
    {
        private string Speaker { get; }
        private int Capacity { get; }

        public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
            : base(title, description, date, time, address)
        {
            Speaker = speaker;
            Capacity = capacity;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
        }
    }
}
