bool Rodando = true;

while (Rodando)
{
    Console.WriteLine();
    Console.WriteLine("Dois numeros aleatorios serão gerados, o algoritimo ira selecionar o maior numero dentre os dois.\n");

    Console.WriteLine("Insira o valor maximo que os numeros podem atingir:");
    int Max = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    Random random = new Random();

    int Num1 = random.Next(0, Max);
    int Num2 = random.Next(0, Max);

    if (Num1 == Num2)
    {
        Console.WriteLine("Os numeros: " + Num1 + " e " + Num2 + " foram gerados, e ambos possuem o mesmo valor: " + Math.Max(Num1, Num2));
    }
    else
    {
        Console.WriteLine("Os numeros: " + Num1 + " e " + Num2 + " foram gerados, e o maior dentre eles é: " + Math.Max(Num1, Num2));
    }

    Console.WriteLine("Pressione qualquer tecla para finalizar, caso deseje gerar outro numero pressione ('S' ou 's')");
    if (Console.ReadKey().Key == ConsoleKey.S)
    {
        Console.WriteLine();

    }
    else
    {
        Rodando = false;
        Console.WriteLine("Programa finalizado");
    }
}