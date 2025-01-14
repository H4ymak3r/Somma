Console.Write("Primo numero: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Secondo numero: ");
int b = int.Parse(Console.ReadLine());

Somma somma = new Somma();

Console.WriteLine(somma.returnSomma(a, b));