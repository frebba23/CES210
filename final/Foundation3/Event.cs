Event Class:
public class Event
{
    // Event Title
    private string title;
    public string Title { get { return title; } set { title = value; } }

    // Event Description
    private string description;
    public string Description { get { return description; } set { description = value; } }

    // Event Date
    private DateTime date;
    public DateTime Date { get { return date; } set { date = value; } }

    // Event Time
    private DateTime time;
    public DateTime Time { get { return time; } set { time = value; } }

    // Event Address
    private Address address;
    public Address Address { get { return address; } set { address = value; } }

    // Generate a message with standard details
    public string GenerateMessage() 
    { 
        return $"{title}, {description}, {date.ToShortDateString()}, {time.ToShortTimeString()}, {address}";
    }
}



Reception Class:
public class Reception : Event
{
    // Registration
    private List<string> registration;
    public List<string> Registration { get { return registration; } set { registration = value; } }

    // RSVP
    private List<string> rsvp;
    public List<string> RSVP { get { return rsvp; } set { rsvp = value; } }

    // Generate an email for RSVP
    public string GenerateMessage()
    {
        return $"{base.GenerateMessage()}, {string.Join(", ", registration)}, {string.Join(", ", rsvp)}";
    }
}