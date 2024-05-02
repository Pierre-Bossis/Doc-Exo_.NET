Console.WriteLine("Voici la suite de Fibonacci.");
int number = 0;
int secondNumber = 0;
int temp = 1;

for (int i = 1;i < 20; i++)
{
    Console.WriteLine(number);
    secondNumber = number;
    number = secondNumber + temp;
    temp = secondNumber;
}