using System;

namespace CodingLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCarClass myNewCar = new MyCarClass("Red", 50000.00);
            
            Console.WriteLine("My colour is: " + myNewCar.colour);
            Console.WriteLine("My price is: " + myNewCar.price);
            myNewCar.StartEngine();

            while(myNewCar.currentSpeed < myNewCar.maxSpeed) {
               myNewCar.AccelerateCar(); 
            }

        }
    }

    class MyCarClass
    {
        public int currentSpeed;
        public string colour;
        public double price;

        public int maxSpeed = 100;

        private bool engineOn = false;

        public MyCarClass(string MyInitialColour, double MyInitialPrice) {
            colour = MyInitialColour;
            price = MyInitialPrice;
        }

        public void StartEngine() {
            engineOn = true;
            currentSpeed = 0;
            Console.WriteLine("Your engine is now on");            
        }

        public void AccelerateCar() {
            if(engineOn == true) {
                currentSpeed = currentSpeed + 10;
                Console.WriteLine("Accelerating! Current speed is: " + currentSpeed);
            }
            else {
                Console.WriteLine("Your engine isn't running - please start the car first!");
            }

        }

        void Break() {
            // Make sure current speed is greater than 10.

            // Reduce speed by 10 from current speed.

            // Send a notification with current speed
        }
    }
}
