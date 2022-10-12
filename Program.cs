
Console.WriteLine("Hello, World!");

Console.WriteLine("Wpisz pierwszą liczbę:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Wpisz dowolną liczbę:");
int number2 = Convert.ToInt32(Console.ReadLine());

int sum = number1 + number2;
int diff = number1 - number2;
int multiply = number1 * number2;  
int div = number2 * number2;

int[] results = {sum, diff, multiply, div};
foreach (int result in results)
{
    string formatString = String.Format("{0,8:G}", result);
    Console.WriteLine(formatString);

}
/*
 Console.WriteLine("Suma:  " + sum);
Console.WriteLine("Różńica:  " + diff);
Console.WriteLine("Iloczyn:  " + muliply);
Console.WriteLine("Iloraz:  " + div);
*/

Console.WriteLine("Suma w systemia szesnastkowym to: " + sum.ToString("X"));