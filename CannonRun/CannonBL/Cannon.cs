using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CannonBL
{
    public class Cannon
    {
        private float GRAVITY = 9.8f; 
        public bool IfCorrectAngle(int angle)
        {
            if(angle>=1&&angle<=90)
            return true;
            return false; 
        }
        public bool IfCorrectSpeed(int speed)
        {
            if (speed > 0 && speed <= 300000)
                return true;
                return false;
        }

        public int Shoot(int angle, int speed)
        {
            int time = 0;
            double height = 0;
            double distance = 0;
            double angleInRadians = (3.1415926536 / 180) * angle;
            while (height >= 0)
            {
                time++;
                distance = speed * Math.Cos(angleInRadians) * time;
                height = (speed * Math.Sin(angleInRadians) * time) - (GRAVITY * Math.Pow(time, 2)) / 2;
            }
            return (int)distance;           
        }
        public bool isShootHit(int distance, int targetLocation)
        {
            if (Math.Abs(distance-targetLocation)<10)
            {
                return true;
            }
            else {
                return false; 
            }
        }


    }
}
