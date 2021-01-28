using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Kauri_Riivik_178943IABB_HW7
{
    class NormalBall
    {
        internal int _ballRadius;
        internal string _ballUID;
        internal double _ballWeight;
        internal string _sponsor;
        internal int _goalDepth;
        internal int _coordinate;
        internal int _goalCoordinates;
        internal int _goalNot;
        internal int _goalHit;

        public NormalBall(string name)
        {
            _sponsor = name;
            _ballWeight = 0.45;
            _ballRadius = 35;
            _ballUID = null;
            _goalDepth = 170;
            _goalCoordinates = 45;
            _goalNot = 0;
            _goalHit= 0;
        }

        // Avarage ball speed is calkulated here
        private double CalculateAvarageSpeed(double startPosition, double finalPosition, double time) //Formula v=s/t
        {
            double speed=0;
            speed = Math.Abs(finalPosition - startPosition) / time;

            return speed;
        }
        public double AvarageSpeed()
        {
            Console.WriteLine("First coordinate:");
            int first = ValidCoordinate();
            Console.WriteLine("Second coordinate:");
            int second = ValidCoordinate();
            double speed = CalculateAvarageSpeed(first, second, 20);
            return speed;
        }
        public int ValidCoordinate()
        {
            int ret = 0;
            bool good = false;
            while (!good)
            {
                Console.WriteLine("Write coordinate of the ball between -45 and 45");
                string inp = Console.ReadLine();
                Console.Clear();
                try
                {
                    ret = SetCoordinates(Int16.Parse(inp));
                    good = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message + "\nPlease try again!");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message + "\nPlease try again!");
                }
                catch (CoordinateNotValid ex)
                {
                    Console.WriteLine(ex.Message + "\nPlease try again!");
                }
            }
            return ret;
        }
        //returns true if it is goal
        public bool CountGoal(int coordinate)
        {
            _coordinate = coordinate;
            bool goal = false;
            if (_coordinate * 100 - _ballRadius >= _goalCoordinates * 100 - _goalDepth)
                goal = true;
            else if (_coordinate * 100 + _ballRadius <= _goalCoordinates * -100 + _goalDepth)
                goal = true;
            return goal;
        }

        //The kinetic energy of hitting the ball with foot.
        public double KineticEnergy(int velocity) //Formula E=mv^2/2
        {
            double kineticE = 0;
            kineticE = _ballWeight * velocity * velocity/ 2;

            return kineticE;
        }

        public void GoalsHitCount(bool goal) //Was or wasn't goal!
        {
            if (goal)
                _goalHit += 1;
            else
                _goalNot += 1;
        }
        public void GoalsHitStats() //printing goal hit stats
        {
            Console.WriteLine("Goals: {0}\nMiss shots: {1}", _goalHit, _goalNot);
        }

        //BallUID with sponsor first four letters from name and 5 random numbers. 
        public virtual void BallUIDSet()
        {
            try //ignoring situation where sponsor name length is less than 4 letters. 
            {
                _ballUID = null; //To reset _ballUID if name is "null". (random numbers are generated and added to the _BallUID)
                _ballUID = _sponsor.Substring(0, 1); //if name length is less than 4 letters, it is still equal with the previous ones. 
                _ballUID = _sponsor.Substring(0, 2);
                _ballUID = _sponsor.Substring(0, 3);
                _ballUID = _sponsor.Substring(0, 4); 
            }
            catch { }
            Random rnd = new Random();
            for (int i = 0; i < 5; i++) //Five random numbers
            {
                _ballUID += rnd.Next(0, 10);
            }
            Console.WriteLine("Ball UID is " + _ballUID); //BallUID print
        }

        private int SetCoordinates(int coordinate)
        {
            if (coordinate > 45 || coordinate < -45)
            {
                throw new CoordinateNotValid(string.Format("Coordinates out of bounds! Coordinates have to be between -45 and 45!"));
            }
            else
                return coordinate;
        }

        public class CoordinateNotValid : Exception
        {
            public CoordinateNotValid(string message)
               : base(message)
            {
            }
        }
    }

    class YouthBall : NormalBall
    {
        public YouthBall(string name):base(name) //Youth ball parameters
        {
            _sponsor = name;
            _ballWeight = 0.38;
            _ballRadius = 28;
            _goalDepth = 140;
        }

        //BallUID with sponsor first 3 letters from name and 3 random numbers. 
        public override void BallUIDSet()
        {
            try //ignoring situation where sponsor name length is less than 3 letters. 
            {
                _ballUID = null; //To reset _ballUID if name is "null". (random numbers are generated and added to the _BallUID)
                _ballUID = _sponsor.Substring(0, 1); //if name length is less than 3 letters, it is still equal with the previous ones. 
                _ballUID = _sponsor.Substring(0, 2);
                _ballUID = _sponsor.Substring(0, 3);
            }
            catch { }
            Random rnd = new Random();
            for (int i = 0; i < 3; i++) //Adds three random numbers
            {
                _ballUID += rnd.Next(0, 10);
            }
            Console.WriteLine("Ball UID is " + _ballUID); //BallUID print
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //normal ball
            NormalBall normal = new NormalBall("Max");
            Console.WriteLine("Normal Football");

            for (int i=0; i<20;i++) //checks if coordinate is in goal or not 20x
            {
                int coordinate = normal.ValidCoordinate();
                bool goal = normal.CountGoal(coordinate);
                normal.GoalsHitCount(goal);
            }
            normal.GoalsHitStats(); //print goals stats
            normal.BallUIDSet();//BallUID set and print
            
            Console.ReadLine();
            Console.Clear();
            for (int e = 0;e < 10;e++)//Calculating Avarage Speed 10x
            {
                double speed = normal.AvarageSpeed();
                Console.WriteLine("Avarage speed: " + speed);
            }
            Console.ReadLine();
            Console.Clear();

            for (int velocity = 1; velocity < 6; velocity++) //Kinetic energy with velocity 1-5
            {
                double kineticEnergy = normal.KineticEnergy(velocity);
                Console.WriteLine("Kinetic Energy at {1}: {0}", kineticEnergy, velocity);
            }

            Console.ReadLine();
            Console.Clear();

            //Youth ball
            YouthBall youth = new YouthBall("Iisreal");
            Console.WriteLine("Youth Football");

            for (int i = 0; i < 20; i++) //checks if coordinate is in goal or not 20x
            {
                int coordinate = youth.ValidCoordinate();
                bool goal = youth.CountGoal(coordinate);
                youth.GoalsHitCount(goal);
            }
            youth.GoalsHitStats(); //print goals stats
            youth.BallUIDSet(); //BallUID set and print

            Console.ReadLine();
            Console.Clear();
            for (int e = 0; e < 10; e++) //Calculating Avarage Speed 10x
            {
                double speed = youth.AvarageSpeed();
                Console.WriteLine("Avarage speed: " + speed);
            }

            Console.ReadLine();
            Console.Clear();
            for (int velocity = 1; velocity < 6; velocity++) //Kinetic energy with velocity 1-5
            {
                double kineticEnergy = youth.KineticEnergy(velocity);
                Console.WriteLine("Kinetic Energy at {1}: {0}",kineticEnergy, velocity);
            }

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("GoodBye!");
            Thread.Sleep(3000);
        }
    }
}
