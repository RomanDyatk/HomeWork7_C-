void Main()
{
    int M = ReadInt("Введите число M: ");
    int N = ReadInt("Введите число N: ");
    int result = FuncAckerman(M, N);
    Console.WriteLine(result);
}

int ReadInt(string str)
{
    Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int FuncAckerman(int m, int n)
{
    if(m < 0 || n < 0)
    return 0;
    
    if(m == 0) 
    return n += 1;

    if(m > 0 && n == 0) 
    return FuncAckerman(m - 1, 1);

    return FuncAckerman(m - 1, FuncAckerman(m, n - 1));
}

Main();