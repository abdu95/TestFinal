using CannonBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CannonRun
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Cannon WAR Game!");

            Console.WriteLine("Enter the target location: ");
            int targetLocation = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an Angle of your cannon: ");
            int angle = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the speed: ");
            int speed = Convert.ToInt32(Console.ReadLine());

            Cannon cannon = new Cannon();
            int distance = cannon.Shoot(angle, speed);

            if(cannon.isShootHit(distance, targetLocation))
            {
                Console.WriteLine("Man, u got it");
                Console.ReadLine();
            }
            else
            { 
            Console.WriteLine("Man, u lost it");
            Console.ReadLine();
            }







        }
    }
}
