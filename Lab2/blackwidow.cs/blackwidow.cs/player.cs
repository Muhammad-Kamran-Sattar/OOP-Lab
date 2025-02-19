using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackwidow.cs
{
    internal class player
    {
        public player() { }
        private string player1 = "@";
        public void movePlayerUp(char[,] maze, ref int playerX, ref int playerY)

        {

            if (maze[playerX - 1, playerY] == ' ' || maze[playerX - 1, playerY] == '.')

            {

                maze[playerX, playerY] = ' ';

                Console.SetCursorPosition(playerY, playerX);

                Console.Write(" ");

                playerX = playerX - 1;

                Console.SetCursorPosition(playerY, playerX);


                Console.Write(player1);


            }


        }

        public void movePlayerDown(char[,] maze, ref int playerX, ref int playerY)

        {

            if (maze[playerX + 1, playerY] == ' ' || maze[playerX + 1, playerY] == '.')

            {

                maze[playerX, playerY] = ' ';

                Console.SetCursorPosition(playerY, playerX);

                Console.Write(" ");

                playerX = playerX + 1;

                Console.SetCursorPosition(playerY, playerX);

                Console.Write(player1);

            }

        }
        public void movePlayerLeft(char[,] maze, ref int playerX, ref int playerY)

        {

            if (maze[playerX, playerY - 1] == ' ' || maze[playerX, playerY - 1] == '.')

            {

                maze[playerX, playerY] = ' ';

                Console.SetCursorPosition(playerY, playerX);

                Console.Write(" ");

                playerY = playerY - 1;

                Console.SetCursorPosition(playerY, playerX);

                Console.Write(player1);

            }

        }
        public void movePlayerRight(char[,] maze, ref int playerX, ref int playerY)

        {

            if (maze[playerX, playerY + 1] == ' ' || maze[playerX, playerY + 1] == '.')

            {

                maze[playerX, playerY] = ' ';

                Console.SetCursorPosition(playerY, playerX);

                Console.Write(" ");

                playerY = playerY + 1;

                Console.SetCursorPosition(playerY, playerX);

                Console.Write(player1);

            }

        }
    }

}
