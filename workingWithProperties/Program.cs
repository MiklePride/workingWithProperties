class Program
{
    static void Main(string[] args)
    {
        Renderer renderer = new Renderer();
        Player player = new Player(4, 6, 'X');

        renderer.DrawPlayer(player.PositionX, player.PositionY, player.Symbol);
    }
}

class Renderer
{
    public void DrawPlayer(int positionX, int positionY, char symbol = '0')
    {
        Console.SetCursorPosition(positionX, positionY);
        Console.WriteLine(symbol);
    }
}

class Player
{
    public char Symbol { get; private set; }
    public int PositionX { get; private set; }
    public int PositionY { get; private set; }

    public Player(int positionX, int positionY, char symbol)
    {

        PositionX = positionX;
        PositionY = positionY;
        Symbol = symbol;
    }
}