Lectures Class:
public class Lecture : Event
{
    // Speaker's Name
    private string speakerName;
    public string SpeakerName { get { return speakerName; } set { speakerName = value; } }

    // Venue Capacity
    private int venueCapacity;
    public int VenueCapacity { get { return venueCapacity; } set { venueCapacity = value; } }

    // Generate a message of speaker's name and venue capacity
    public string GenerateMessage()
    {
        return $"{base.GenerateMessage()}, {speakerName}, {venueCapacity}";
    }
}