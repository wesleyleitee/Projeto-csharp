Console.WriteLine("Learning - Recursion");

Console.Write("Enter the size of the pyramid:");

string? entry = Console.ReadLine();

int.TryParse(entry, out int height);

draw(height);

void draw(int n){
    if (n <= 0) return;

    // Print a pyramid of height n - 1
    draw(n - 1);

    // Print one more row
    for (int i = 0; i < n; i++)
    {
        Console.Write("#");
    }

    Console.Write("\n");
}