Console.WriteLine("Bubble Sort");

//compara números vizinhos e realiza trocas.
int[] numeros = { 7, 3, 9, 1, 5, 8, 2, 6, 4 };

ExibirArray(numeros, "Array original: ");

BubbleSort(numeros);

ExibirArray(numeros, "Array ordenado: ");

static void BubbleSort(int[] array)
{
    // Controla a quantidade de passadas pelo array
    for (int passada = 0; passada < array.Length - 1; passada++)
    {
        bool realizouTroca = false;

        // Compara números vizinhos
        for (int i = 0; i < array.Length - 1 - passada; i++)
        {
            // Verifica se os números estão na ordem errada
            if (array[i] > array[i + 1])
            {
                // Realiza a troca
                int temporario = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temporario;

                realizouTroca = true;
            }
        }

        ExibirArray(array, $"Passada {passada + 1}: ");

        // Se nenhuma troca aconteceu,
        // significa que o array já está ordenado
        if (!realizouTroca)
        {
            break;
        }
    }
}

static void ExibirArray(int[] array, string mensagem)
{
    Console.WriteLine(mensagem + string.Join(", ", array));
}