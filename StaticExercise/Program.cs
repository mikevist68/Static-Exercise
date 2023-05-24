namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(55.8);
            Console.WriteLine($"Whats the conversion from celsius to {fahrenheit}");

            var celius = TempConverter.FahrenheitToCelsius(20.2);
            Console.WriteLine($"Whats the conversion from fahrenheit to {celius}");
        }
    }
}
