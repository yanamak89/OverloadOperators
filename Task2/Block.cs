namespace Task2;

public class Block
{
    private int a, b, x, y;

    public Block(int aPos, int bPos, int xPos, int yPos)
    {
        a = aPos;
        b = bPos;
        x = xPos;
        y = yPos;
    }
    
    public override string ToString()
    {
        return string.Format("[{0}, {1}, {2}, {3}]", this.a, this.b, this.x, this.y);
    }

    public override bool Equals(Object o)
    {
        if (o is Block)
        {
            Block other = (Block)o;
            return other.a == this.a && other.b == this.b && other.x == this.x && other.y == this.y;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return this.ToString().GetHashCode();
    }

}