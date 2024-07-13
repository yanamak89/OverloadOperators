using Task4;

class Program
{
    static void Main()
    {
        Date date1 = new Date(1, 1, 2020);
        Date date2 = new Date(20, 1, 2020);
        
        // Обчислення різниці між датами
        int difference = date1 - date2; 
        Console.WriteLine($"Difference btw {date1} and {date2}" +
                          $" is {difference}");
        
        // Додавання днів до дати
        int daysAdded = 14;
        Date newDate = date1 + daysAdded;
        Console.WriteLine($"New date after adding {daysAdded} is" +
                          $" {newDate}");
    }
}