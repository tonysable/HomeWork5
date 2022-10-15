void Main()
{
    int[] array = new int[5]; 
    Random abc = new Random(); 
    for(int i = 0; i < 5; i++) 
    {
        array[i] = abc.Next(100, 1000);
    }
    Console.Write("["); 
    for(int i = 0; i < 4; i++) 
    {
        Console.Write(array[i]); 
        Console.Write(", ");

    }
    Console.Write(array[4]); 

    
    Console.Write("] => ");
    int sum = 0; 
    for(int i = 1; i < 5; i+=2) 
    {
        sum += array[i];    
        }
    Console.WriteLine(sum); 
}
Main();
