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

            int oneup;
            float goblin_sdam;
            float goblin_hdam;
            int goblin_score;
            int score_mp;

            title = "John's Variable Project";
            studio = "John Wohler";
            score = 0;
            health = 100;
            shield = 50;
            lives = 3;

            oneup = 1;
            goblin_sdam= 10.0f;
            goblin_hdam = 10.0f;
            goblin_score = 5;
            score_mp = 3;
            Console.WriteLine(title);

            Console.WriteLine("By " + studio);

            Console.WriteLine("Lives: " + lives);

            Console.WriteLine("Shield: " + shield);
            
            Console.WriteLine("Health: " + health);

            Console.WriteLine("Score:" + score);

            Console.WriteLine("" + "");
            
            Console.WriteLine("" + "");

            Console.WriteLine("Press Any Key to gain a life.");


            Console.ReadKey(true);

            lives = lives + oneup;
            
            Console.WriteLine("" + "");

            Console.WriteLine("" + "");

            Console.WriteLine("Lives " + lives+"<---");

            Console.WriteLine("Shield " + shield);

            Console.WriteLine("Health " + health);

            Console.WriteLine("Score " + score);

            Console.WriteLine("" + "");
            
            Console.WriteLine("" + "");

            Console.WriteLine("Good job! Now Press Any Key to make see how much damage a Goblin does to your shield.");
            

            Console.ReadKey(true);

            shield = shield - goblin_sdam;

            Console.WriteLine("" + "");

            Console.WriteLine("" + "");

            Console.WriteLine("Lives " + lives);

            Console.WriteLine("Shield " + shield+"<---");

            Console.WriteLine("Health " + health);

            Console.WriteLine("Score " + score);

            Console.WriteLine("" + "");

            Console.WriteLine("" + "");

            Console.WriteLine("Good Job! Now, Press Any Key and let's see how much damage a Goblin would do to your health directly.");


            Console.ReadKey(true);

            health=health - goblin_hdam;

            Console.WriteLine("" + "");
            
            Console.WriteLine("" + "");

            Console.WriteLine("Lives " + lives);

            Console.WriteLine("Shield " + shield);

            Console.WriteLine("Health " + health+"<---");

            Console.WriteLine("Score " + score);

            Console.WriteLine("" + "");
            
            Console.WriteLine("" + "");

            Console.WriteLine("Ouch! Alright, now let's give you an increase in score for all your trouble. You know the drill by now, Press Any Key when you're ready.");


            Console.ReadKey(true);

            score = score + goblin_score;

            Console.WriteLine("" + "");

            Console.WriteLine("" + "");

            Console.WriteLine("Lives " + lives);

            Console.WriteLine("Shield " + shield);

            Console.WriteLine("Health " + health);

            Console.WriteLine("Score " + score+"<---");

            Console.WriteLine("" + "");

            Console.WriteLine("" + "");

            Console.WriteLine("Look at that, five whole points! You know what, just because it's the end of the game, let's triple your score! Press Any Key to win!");


            Console.ReadKey(true);

            score = score * score_mp;

            Console.WriteLine("Lives " + lives);

            Console.WriteLine("Shield " + shield);

            Console.WriteLine("Health " + health);

            Console.WriteLine("Score " + score+"<---");

            Console.WriteLine("" + "");

            Console.WriteLine("" + "");

            Console.WriteLine("Congratulations! You survived the Goblin's attack long enough for him to die of old age.");

            Console.WriteLine("" + "");
            
            Console.WriteLine("" + "");
            
            Console.WriteLine("" + "");
            
            Console.WriteLine("" + "");
            Console.WriteLine("                                   ___________");
            Console.WriteLine("                                ___I         I___");
            Console.WriteLine("                              __I               I__");
            Console.WriteLine("                              I                   I");
            Console.WriteLine("                              I                   I");
            Console.WriteLine("                              I        RIP        I");
            Console.WriteLine("                              I                   I");
            Console.WriteLine("                              I      Goblin 1     I");
            Console.WriteLine("                              I   Beloved Enemy   I");
            Console.WriteLine("                              I                   I");
            Console.WriteLine("             #                I                   I");
            Console.WriteLine("            /                 I                   I");
            Console.WriteLine("           /           #      I    /              I");
            Console.WriteLine("        / /     /     /       I   /            /  I /    /  /");
            Console.WriteLine("/// // / /  // / /   / //  / /I /// /   / /   / / //  / //  /  / / // / / /");

            Console.ReadKey(true);
        }
    }
}
