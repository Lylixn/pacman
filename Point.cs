using Pacman.utils;

namespace Pacman;

public class Point
{
    public Position Position { get; set; }
    public bool IsEaten { get; set; }
    
    public Point(int x, int y)
    {
        Position = new Position(x, y);
        IsEaten = false;
    }
    
    public void CheckCollision()
    {
        if (Game.Player.Position.X == Position.X && Game.Player.Position.Y == Position.Y)
        {
            if (IsEaten) return;
            IsEaten = true;
            Game.Score += 10;
        }
    }

    public void Draw()
    {
        if (IsEaten) return;
        Console.SetCursorPosition(Position.X, Position.Y + 1);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write('·');
        Console.ResetColor();
    }
}