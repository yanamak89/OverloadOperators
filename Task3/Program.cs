using Task3;

class Program()
{
    static void Main()
    {
        Address address = new Address{Street = "ul. Fort 123", City = "Warsaw", Country = "Poland"};
        House originalHouse = new House { Address = address, Rooms = 5};
        House shallowClone = (House)originalHouse.Clone();
        House deepClone = originalHouse.DeepClone();
        
        Console.WriteLine("Original house: " + originalHouse);
        Console.WriteLine("Shallow clone house: " + shallowClone);
        Console.WriteLine("Deep clone house: " + deepClone);
        
        // Змінимо дані в оригінальному об'єкті
        originalHouse.Address.Street = "Bruzdowa 106";
        
        Console.WriteLine("After I made some changes in the original house: ");
        Console.WriteLine("Original house: " + originalHouse);
        Console.WriteLine("Shallow clone house: " + shallowClone);
        Console.WriteLine("Deep clone house: " + deepClone);

    }


}