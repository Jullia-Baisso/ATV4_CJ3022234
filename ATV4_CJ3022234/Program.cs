int num1, num2, op, resultado;
 
Console.WriteLine("Digite o primeiro número:");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número:");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite 1 para adição");
Console.WriteLine("Digite 2 para subtração");
Console.WriteLine("Digite 3 para multiplicação");
Console.WriteLine("Digite 4 para divisão");
op = int.Parse(Console.ReadLine());

switch (op)
{

    case 1:
        resultado = num1 + num2;
        Console.WriteLine(resultado);
        break;
    case 2:
        resultado = num1 - num2;
        Console.WriteLine(resultado);
        break;
    case 3:
        resultado = num1 * num2;
        Console.WriteLine(resultado);
        break;
    case 4:
        resultado = num1 / num2;
        Console.WriteLine(resultado);
        break;
}











