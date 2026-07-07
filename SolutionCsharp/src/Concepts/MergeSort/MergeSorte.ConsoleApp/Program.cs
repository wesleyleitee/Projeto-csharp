Console.WriteLine("Merge Sort");

//divide o array em partes menores e depois junta tudo ordenado.
int[] numeros = { 7, 3, 9, 1, 5, 8, 2, 6, 4 };

ExibirArray(numeros, "Array original: ");

MergeSort(numeros, 0, numeros.Length - 1);

ExibirArray(numeros, "Array ordenado: ");

static void MergeSort(int[] array, int inicio, int fim)
{
    // Se existe somente um elemento,
    // não é necessário continuar dividindo
    if (inicio >= fim)
    {
        return;
    }

    // Encontra a posição do meio
    int meio = (inicio + fim) / 2;

    // Ordena a metade esquerda
    MergeSort(array, inicio, meio);

    // Ordena a metade direita
    MergeSort(array, meio + 1, fim);

    // Junta as duas metades
    Juntar(array, inicio, meio, fim);

    ExibirArray(
        array,
        $"Juntando as posições {inicio} até {fim}: "
    );
}

static void Juntar(int[] array, int inicio, int meio, int fim)
{
    int tamanhoEsquerda = meio - inicio + 1;
    int tamanhoDireita = fim - meio;

    int[] esquerda = new int[tamanhoEsquerda];
    int[] direita = new int[tamanhoDireita];

    // Copia os números da metade esquerda
    for (int i = 0; i < tamanhoEsquerda; i++)
    {
        esquerda[i] = array[inicio + i];
    }

    // Copia os números da metade direita
    for (int i = 0; i < tamanhoDireita; i++)
    {
        direita[i] = array[meio + 1 + i];
    }

    int indiceEsquerda = 0;
    int indiceDireita = 0;
    int indiceArray = inicio;

    // Compara os números das duas metades
    while (
        indiceEsquerda < tamanhoEsquerda &&
        indiceDireita < tamanhoDireita
    )
    {
        if (esquerda[indiceEsquerda] <= direita[indiceDireita])
        {
            array[indiceArray] = esquerda[indiceEsquerda];
            indiceEsquerda++;
        }
        else
        {
            array[indiceArray] = direita[indiceDireita];
            indiceDireita++;
        }

        indiceArray++;
    }

    // Copia os números restantes da esquerda
    while (indiceEsquerda < tamanhoEsquerda)
    {
        array[indiceArray] = esquerda[indiceEsquerda];

        indiceEsquerda++;
        indiceArray++;
    }

    // Copia os números restantes da direita
    while (indiceDireita < tamanhoDireita)
    {
        array[indiceArray] = direita[indiceDireita];

        indiceDireita++;
        indiceArray++;
    }
}

static void ExibirArray(int[] array, string mensagem)
{
    Console.WriteLine(mensagem + string.Join(", ", array));
}