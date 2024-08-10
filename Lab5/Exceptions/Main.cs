/* 
Description: Circle class that throws an exception if the radius is less than or equal to zero.

Name: Ashleen Sidhu
Date: 2021-07-16
*/
namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Circle circle1 = new Circle(5);
                circle1.SetRadius(5);
                Console.WriteLine(circle1.ToString());

                Circle circle2 = new Circle(-3);
                circle2.SetRadius(-3);
                Console.WriteLine(circle2.ToString());
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Circle circle3 = new Circle(0);
                circle3.SetRadius(0);
                Console.WriteLine(circle3.ToString());
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}
