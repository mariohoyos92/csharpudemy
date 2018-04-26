using System;

namespace FollowingAlongWithUdemyCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes mer = new Mercedes();
            mer.DisplayInfor();
        }

    }

    class Cars 
    {
        private decimal price;
        protected int maxSpeed;
        public string color;

        protected decimal Price {
            get { return price; } set { price = value; }
        }

        public virtual void DisplayInfor()
        {
            price = 1000;
            maxSpeed = 300;
            color = "black";

            Console.WriteLine($"Default price is {price} and the maxspeed is {maxSpeed} and the color is {color}");
        }
    }

    class Mercedes : Cars 
    {
        public override void DisplayInfor()
        {
            base.DisplayInfor();

            base.maxSpeed = 1500;
            base.color = "red";
            base.Price = 2000;

            Console.WriteLine($"Default price is {Price} and the maxspeed is {maxSpeed} and the color is {color}");

        }
    }
}
