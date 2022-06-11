class Program
{
    static void Main(string[] args)
    {
        Renderer renderer = new Renderer();
        Player player = new Player(4, 15);

        renderer.DrawPlayer(player.PlayerPositionX, player.PlayerPositionY);
    }
}

class Renderer
{
    public void DrawPlayer(int positionX, int positionY, char player = '0')
    {
        Console.SetCursorPosition(positionX, positionY);
        Console.WriteLine(player);
    }
}

class Player
{
    private int _playerPositionX;
    private int _playerPositionY;

    public int PlayerPositionX { get; private set; }
    public int PlayerPositionY { get; private set; }

    public Player(int playerPositionX, int playerPositionY)
    {
        PlayerPositionX = playerPositionX;
        PlayerPositionY = playerPositionY;
    }
}