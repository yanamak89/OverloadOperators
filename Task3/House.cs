namespace Task3;

public class House : ICloneable
{
    public int Rooms { get; set; }
    public Address Address { get; set; }

    public object Clone()
    {
        return this.MemberwiseClone();
    }

    public House DeepClone()
    {
        House clone = (House)this.MemberwiseClone();
        clone.Address = this.Address.Clone();
        return clone;
    }

    public override string ToString()
    {
        return $"House with {Rooms} rooms and address: {Address}.";
    }
}
