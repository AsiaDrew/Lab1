public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");
        Console.WriteLine();

        //prompt user
        Console.Write("Enter length: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Enter Width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Enter a height: ");
        double height = double.Parse(Console.ReadLine());

        //variables
        double area = length * width;
        double perimeter = 2 *(length + width);
        double volume = length * width * height;
        double surfaceArea = ((length * width) + (height * width) + (length * height)) *2;

        //display back
        Console.WriteLine();
        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Perimeter: {perimeter}");
        Console.WriteLine();
        Console.WriteLine($"Volume for this room is: {volume}");
        Console.WriteLine($"Surface Area for this room is: {surfaceArea}");
        Console.WriteLine();

        //extra challenge
        if (area <= 250)
        {
            Console.WriteLine("This room is small.");
        }
        else if (area > 250 && area < 650)
        {
            Console.WriteLine("This room is medium.");
        }
        else if (area >= 650)
        {
            Console.WriteLine("This room is large.");
        }

        Console.WriteLine("Thank you for using the Room Detail Generator!");
    }
}