using Task2;

class Program
{
    static void Main()
    {
        Block block1 = new Block(2, 3, 4, 5);
        Block block2 = new Block(2, 3, 4, 5);
        Block block3 = new Block(4, 19, 4, 5);

        Console.WriteLine("Block 1: " + block1.ToString());
        Console.WriteLine("Block 2: " + block2.ToString());
        Console.WriteLine("Block 3: " + block3.ToString());
        
        Console.WriteLine("Block 1 == Block2? -> " + block1.Equals(block2));
        Console.WriteLine("Block 2 == Block3? -> " +block2.Equals(block3));
        Console.WriteLine("Block 1 == Block2? -> " + block1.Equals(block3));
    }
}