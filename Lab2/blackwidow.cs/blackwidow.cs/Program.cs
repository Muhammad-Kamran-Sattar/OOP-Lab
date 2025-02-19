using blackwidow.cs;
using EZInput;

internal class Program
{
    private static void Main(string[] args)
    {
        Body m = new Body();
        player y=new player();
        enemy z = new enemy();
        int playerx = 4,playery=4;
        int ex1=4,ey1=10;
        m.Display();
        m.PrintMaze();
        Console.SetCursorPosition(playery, playerx);
        while (true)
        {
            
            Thread.Sleep(100);
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {

               y.movePlayerUp(m.maze, ref playerx, ref playery);

            }

            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {

                y.movePlayerDown(m.maze, ref playerx, ref playery);

            }

            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {

                y.movePlayerLeft(m.maze, ref playerx, ref playery);

            }

            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {

                y.movePlayerRight(m.maze, ref playerx, ref playery);

            }
            z.enemyMove(ref ex1, ref ey1);
        }

    }
}