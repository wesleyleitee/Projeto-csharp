Console.WriteLine("Selection Sort");

//procura o menor número e coloca na posição correta.
int[] numeros = { 7, 3, 9, 1, 5, 8, 2, 6, 4 };

ExibirArray(numeros, "Array original: ");

SelectionSort(numeros);

ExibirArray(numeros, "Array ordenado: ");

static void SelectionSort(int[] array)
{
    // Percorre cada posição do array
    for (int i = 0; i < array.Length - 1; i++)
    {
        // Inicialmente, consideramos que o menor número está na posição atual        
        int indiceMenor = i;

        // Procura um número menor nas próximas posições
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[indiceMenor])
            {
                indiceMenor = j;
            }
        }

        // Troca o número da posição atual pelo menor encontrado
        int temporario = array[i];
        array[i] = array[indiceMenor];
        array[indiceMenor] = temporario;

        ExibirArray(array, $"Passo {i + 1}: ");
    }
}

static void ExibirArray(int[] array, string mensagem)
{
    Console.WriteLine(mensagem + string.Join(", ", array));
}

/*
 O Selection Sort procura o menor número da parte ainda não ordenada e o coloca na posição atual.

Por exemplo:

7, 3, 9, 1, 5

O menor número é 1. Então ele troca o 7 pelo 1:

1, 3, 9, 7, 5
 */