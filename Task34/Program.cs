void Main()
{
    int[] arr = new int[5];
    Random abc = new Random();
    for(int i = 0; i < 5; i++)
    {
        arr[i] = abc.Next(100, 1000);
    }
    int count = 0;
    Console.Write("[");
    for(int i = 0; i < 4; i++)
    {
        Console.Write(arr[i]);
        Console.Write(", ");
        if(arr[i] % 2 == 0) count++;
    }
    Console.Write(arr[4]);

    if(arr[4] % 2 == 0) count++;
    Console.Write("] => ");
    Console.Write(count);
}
Main();