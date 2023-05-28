using System;
class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture
        {
            EventTitle = "Introduction to The Book of Mormon",
            EventDescription = "Learn of the origins and stories of the Book of Mormon",
            EventDate = DateTime.Now.Date,
            EventTime = new TimeSpan(10, 0, 0),
            EventAddress = new Address { Street = "3431 W Wights Ft Rd", City = "West Jordan", State = "Utah", ZipCode = "84088" },
            Speaker = "Brother John Smith",
            Capacity = 150
        };

        Reception reception = new Reception
        {
            EventTitle = "5th Ward Spring Meetup",
            EventDescription = "Join the 5th wards annual spring gathering and say hello to your brothers and sisters.",
            EventDate = DateTime.Now.Date.AddDays(7),
            EventTime = new TimeSpan(18, 0, 0),
            EventAddress = new Address { Street = "545 E 4th N St", City = "Price", State = "Utah", ZipCode = "84501" },
            RsvpEmail = "rsvp@example.com"
        };

        OutdoorGathering outdoorGathering = new OutdoorGathering
        {
            EventTitle = "Singles picnic in the Park",
            EventDescription = "Enjoy a fun day outdoors with games and food",
            EventDate = DateTime.Now.Date.AddDays(14),
            EventTime = new TimeSpan(12, 0, 0),
            EventAddress = new Address { Street = "545 E 4th N St", City = "Price", State = "Utah", ZipCode = "84501" },
            WeatherForecast = "Slightly cloudy with a chance of thunderstorms"
        };

        Console.WriteLine("Lecture:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetShortDescription());

        Console.ReadLine();
    }
}