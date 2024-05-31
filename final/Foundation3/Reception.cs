namespace EventPlanning
{
    public class Reception : Event
    {
        private string RSVPEmail { get; }

        public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
            : base(title, description, date, time, address)
        {
            RSVPEmail = rsvpEmail;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {RSVPEmail}";
        }
    }
}
