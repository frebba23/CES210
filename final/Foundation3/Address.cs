Address Class:
public class Address
{
    // Street
    private string street;
    public string Street { get { return street; } set { street = value; } }

    // City
    private string city;
    public string City { get { return city; } set { city = value; } }

    // State
    private string state;
    public string State { get { return state; } set { state = value; } }

    // Zip Code
    private string zipCode;
    public string ZipCode { get { return zipCode; } set { zipCode = value; } }

    public override string ToString()
    {
        return $"{street}, {city}, {state}, {zipCode}";
    }
}