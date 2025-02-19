using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackwidow.cs
{
    internal class enemy
    {
        public enemy() { }
        private string enemy1 = "*";
        public void enemyMove( ref int ex1, ref int  ey1)
        {

           
                Console.SetCursorPosition(ey1, ex1);
                Console.Write(" ");
                ey1 = ey1 + 1;
                Console.SetCursorPosition(ey1, ex1);
                Console.Write(enemy1);
            
            if (ey1 == 28)
                {
                Console.SetCursorPosition(ey1, ex1);
                Console.Write(" ");
                ey1 =4;
                }
              

            
        }
    }
}
