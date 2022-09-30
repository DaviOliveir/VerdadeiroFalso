int n1, n2;

Console.WriteLine("divisao de dois numeros");


Console.WriteLine("digite seu primeriro numero");
n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("digite seu segundo numero");
n2 = Convert.ToInt32(Console.ReadLine());


if (n2==0)

{Console.WriteLine("nao é possivel dividir por zero");}

else
{double resultado = n1/n2;}