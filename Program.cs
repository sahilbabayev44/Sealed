namespace Sealed
{
    internal class Program
    {
        static void Main()
        {
            Addition addition = new Addition();

            Substraction substraction = new Substraction();

            Multiplication multiplication = new Multiplication();

            Division division = new Division();

            Console.WriteLine($"Addition : first number = {1}, second number = {5}. Result ={addition.Operate(1,5)}");
            Console.WriteLine($"Subscration : first number = {10},seond number = {5}. Result ={substraction.Operate(10, 5)} ");
            Console.WriteLine($"Multiplication first number = { 7}, second number = { 2 }. Result ={ multiplication.Operate(7, 2)}");
            Console.WriteLine($"Dvision first number = {20}, second number = {4}. Result ={division.Operate(1, 5)}");

        }

    }
}