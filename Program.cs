Console.WriteLine("Array Loop");

Console.WriteLine("Ingrese la cantidad de numeros: ");
int[] numbers = new int[Int32.Parse(Console.ReadLine() ?? "0")];

// Llenamos el arrary
for (int i = 0; i< numbers.Length; i++ )
{
    Console.WriteLine("ingrese un numero: ");
    string input = Console.ReadLine() ?? "0";
    numbers[i] = Int32.Parse(input);
}    

// Sumamos el array
int total = 0; 
for (int i =0; i < numbers.Length; i++)
{
    total = total + numbers[i];
}

// Imprimimos array
for (int i =0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

Console.WriteLine("Total: " + total);