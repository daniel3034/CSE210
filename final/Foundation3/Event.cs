namespace EventPlanning
{
    public abstract class Event
    {
        private string Title { get; }
        private string Description { get; }
        private DateTime Date { get; }
        private string Time { get; }
        private Address Address { get; }

        protected Event(string title, string description, DateTime date, string time, Address address)
        {
            Title = title;
            Description = description;
            Date = date;
            Time = time;
            Address = address;
        }

        public string GetStandardDetails()
        {
            return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {Address.GetFullAddress()}";
        }

        public abstract string GetFullDetails();

        public string GetShortDescription()
        {
            return $"{GetType().Name}: {Title} on {Date.ToShortDateString()}";
        }
    }
}
