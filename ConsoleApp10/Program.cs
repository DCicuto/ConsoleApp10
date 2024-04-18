
int n1 = 0, max = 0, contador = 0, aux = 0;

Console.WriteLine("Digite um numero");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um numero incrementador");
max = int.Parse(Console.ReadLine());

Console.WriteLine("Aqui é o for");
aux = 1;
for (contador = 0; contador <= max; contador++) ;
{
    Console.WriteLine(n1);
    n1 = n1 + i;
}

Console.WriteLine("Aqui é o do");
aux = n1;

do
{
    Console.WriteLine(aux);
    aux++;
    contador++;
} while (contador <= max);

contador = 0;

Console.WriteLine("Aqui é o while");
aux = n1;

while (contador <= max) ;
{
    Console.WriteLine(aux);
    aux++;
    contador++;
}