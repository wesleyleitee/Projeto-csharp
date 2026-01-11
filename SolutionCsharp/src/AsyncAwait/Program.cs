int resultado = CalcularFatorial(5);
Console.WriteLine($"O fatorial é: {resultado}");


// Método principal
static int CalcularFatorial(int numero)
{
    // Método local: só existe dentro de CalcularFatorial
    int Fatorial(int n)
    {
        if (n <= 1)
            return 1;
        return n * Fatorial(n - 1); // chamada recursiva
    }

    // Aqui podemos validar antes de chamar o método local
    if (numero < 0)
        throw new ArgumentException("O número não pode ser negativo.");

    return Fatorial(numero);
}