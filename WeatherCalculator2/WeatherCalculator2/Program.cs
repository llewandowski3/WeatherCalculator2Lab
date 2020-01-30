using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Weather Calculator 2");

            int temperature;
            int windSpeed;
            double windChill;
            string input = "";
            int humidity;
            

            // Get the temperature from the user
            Console.WriteLine("Enter the temperature in Fahrenheit");

            input = Console.ReadLine();

            temperature = int.Parse(input);
            if (temperature < 50)
            {

                // Get the windspeed from the user
                Console.WriteLine("Enter the wind speed");

                input = Console.ReadLine();

                windSpeed = int.Parse(input);

                // Calculate the wind chill

                windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

                Console.WriteLine("The wind chill is " + windChill);
            }
            else
            {
                Console.WriteLine("Enter the Relitive Humidity");

                input = Console.ReadLine();

                humidity = int.Parse(input);

                // Calculate Heat Index
                double HI = .5 * (temperature + 61.0 + ((temperature - 68.0) * 1.2) + (humidity * 0.094));

                Console.WriteLine("The heat index is"+ HI);
            }

            



        }
    }
}
