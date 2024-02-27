void Main()
{
    int length = 5;
    int index = length - 1;
    int[] array = new int[length];
    FillingArray(array);

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }

    Console.WriteLine();

    PrintArray(array, index);

}

void FillingArray(int[] array)
{
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 50);
    }

}

void PrintArray(int[] array, int index)
{
    if(index < 0) return;
    Console.Write(array[index] + "\t");
    PrintArray(array, index - 1); 
}

Main();
