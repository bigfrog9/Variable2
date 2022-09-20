using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String studio;
            String title;
            int score;
            float health;
            float shield;
            int lives;

            title = "John's Variable Project 2";
            studio = "John Wohler";
            score = 0;
            health = 100;
            shield = 50;
            lives = 3;

            Console.WriteLine(title);

            Console.WriteLine("By " + studio);

            Console.WriteLine("Lives: " + lives);

            Console.WriteLine("Shield: " + shield);
            
            Console.WriteLine("Health: " + health);

            Console.WriteLine("Score:" + score);


            Console.ReadKey(true);

            Console.ReadKey(true);
        }
    }
}
