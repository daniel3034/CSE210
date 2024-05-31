using System;
using System.Collections.Generic;

namespace EventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            var address1 = new Address("123 Main St", "Anytown", "CA", "USA");
            var lecture = new Lecture("AI and the Future", "A talk on the impact of AI", new DateTime(2024, 6, 10), "10:00 AM", address1, "Dr. Jane Doe", 100);

            var address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");
            var reception = new Reception("Networking Event", "An evening to network with professionals", new DateTime(2024, 7, 15), "6:00 PM", address2, "rsvp@example.com");

            var address3 = new Address("789 Pine St", "Elsewhere", "TX", "USA");
            var outdoorGathering = new OutdoorGathering("Community Picnic", "A fun day out with the community", new DateTime(2024, 8, 20), "11:00 AM", address3, "Sunny");

            List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

            foreach (var eventItem in events)
            {
                Console.WriteLine("Standard Details:");
                Console.WriteLine(eventItem.GetStandardDetails());
                Console.WriteLine();

                Console.WriteLine("Full Details:");
                Console.WriteLine(eventItem.GetFullDetails());
                Console.WriteLine();

                Console.WriteLine("Short Description:");
                Console.WriteLine(eventItem.GetShortDescription());
                Console.WriteLine("-------------------------------------------------\n");
            }
        }
    }
}
