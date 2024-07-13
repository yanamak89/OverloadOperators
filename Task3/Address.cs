namespace Task3;

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string Country { get; set; }

    public Address Clone()
    {
        return (Address)this.MemberwiseClone();
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {Country}";
    }
}