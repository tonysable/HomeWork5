void Main()   
{
    double[] array = new double[6];
    Random abd = new Random();
    for(int i = 0; i < 6; i++)
    {
        array[i] = abd.Next(100, 1000) / 10.0;

    }

    Console.Write("["); 
    for(int i = 0; i < 5; i++) 
    {
        Console.Write(array[i]); 
        Console.Write(", ");

    }
    Console.Write(array[5]);
    Console.Write("] => ");

    double max = array[0];
    double min = array[0];
    for(int i = 0; i < 6; i++)
    {
        if(max < array[i]) max = array[i];
        if(min > array[i]) min = array[i];
    }
    double diff = max - min;
    Console.Write(Math.Round(diff, 2));
}
Main();