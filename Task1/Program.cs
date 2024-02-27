void Main()
{
    int M = ReadInt("Введите число M: ");
    int N = ReadInt("Введите число N: ");
    PrintNumbers(M, N);
}

int ReadInt(string str)
{
    Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int m, int n)
{
    if(m > n) return;
    
    Console.Write(m + "\t");
    PrintNumbers(m + 1, n);
}

Main();
