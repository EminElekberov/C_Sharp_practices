using System;

namespace Simple_CSharp_practices
{
    public enum ImageOrientation
    {
        Landscape,
        Portrait
    }
    class Image
    {
        public void Orientation()
        {
            Console.Write("Image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is " + orientation);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            #region Task-1
            /// <summary>
            /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
            /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
            /// applications where values entered into input boxes need to be validated.)
            /// </summary>
            Console.WriteLine("Please, enter value between 1-10");
            int num = int.Parse(Console.ReadLine());

            string result = (1 <= num && num <= 10) ? "Valid!" : "Invalid!";
            Console.WriteLine(result);
            #endregion

            #region Task-2
            /// <summary>
            /// Write a program which takes two numbers from the console and displays the maximum of the two.
            /// </summary>
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());

            int max = (num1 > num2) ? num1 : num2;

            string answer = string.Format("number 1: {0}, number 2: {1} \nMaximum is: {2}", num1, num2, max);
            Console.WriteLine(answer);
            #endregion

            #region Task-3
            /// <summary>
            /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
            /// is landscape or portrait.
            /// </summary>
            
            //var ex3 = new Image();
            //ex3.Orientation();

            Console.WriteLine("Enter width: ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter length: ");
            double length = double.Parse(Console.ReadLine());

            string imageType = (width > length ? "portrait" : "landscape");
            Console.WriteLine("These sizes are fits to" + " " + imageType);
            #endregion

            #region Task-4
            /// <summary>
            /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
            /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
            /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
            /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
            /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
            /// the console. If the number of demerit points is above 12, the program should display License Suspended.
            /// </summary>
            Console.WriteLine("Enter the speed limit: ");
            double speedLimit = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the speed of car: ");
            double carSpeed = double.Parse(Console.ReadLine());

            int demeritPoints;
            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                demeritPoints = Convert.ToInt32((carSpeed - speedLimit) / 5);
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }
            #endregion
        }
    }
}
