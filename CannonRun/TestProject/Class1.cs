using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CannonBL; 

namespace TestProject
{
    [TestFixture]
    public class Class1
    {
        CannonBL.Cannon cn; 
        public Class1()
        {
             cn= new Cannon();
        }

        [Test]
        public void firstTest()
        {
            Assert.Pass(); 
        }

        [Test]
        public void CannonRangeAngleTest()
        {
            //test for range of angle 
            //MinAngle = 1, MaxAngle = 90
            Assert.IsTrue(cn.IfCorrectAngle(90)); 
        }

        [Test]
        public void CannonRangeSpeedTest()
        {
            //test for range of speed             
            Assert.IsTrue(cn.IfCorrectSpeed(50));
        }
        [Test]
        public void CannonRangeSpeedTestFails()
        {
            //test for range of speed             
            Assert.IsFalse(cn.IfCorrectSpeed(300000000));
        }
        [Test]
        public void CannonShootTest()
        {
            int angle = 45;
            int speed = 80;  
            Assert.IsTrue(cn.IfCorrectSpeed(speed));
            Assert.IsTrue(cn.IfCorrectAngle(angle));
            //test for range of speed             
            Assert.IsTrue(cn.Shoot(angle, speed)>0);
        }
        //if it is a login page, if I enter avaz with password 12345
        //it is suppose to pass.

        [Test]
        public void CannonHit800Test()
        {
            //we know that 25,100 ...it should match 815 +-10.

            int distance = cn.Shoot(25, 100); 
            //test for range of speed                        
            Assert.IsTrue(cn.isShootHit(distance, 812));
        }

        [Test]
        public void CannonHit500Test()
        {
            int distance = cn.Shoot(25, 100);
            Assert.IsFalse(cn.isShootHit(distance, 500));
        }

        }
}
