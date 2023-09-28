namespace Task_23_Convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите строку");

                string? str = Console.ReadLine();

                if (str != string.Empty && str != null)
                {
                    double value = ConverterDouble.GetDouble(str);

                    if (value == 0)
                    {
                        Console.WriteLine("\nВ строке нет цифр либо в строке слишком длинное число");
                    }
                    else
                    {
                        Console.WriteLine($"\nВаше число {value}");
                    }
                }

                Console.ReadKey();

                Console.Clear();
            }
        }
    }
}