using System;

class Program {
    public static void FillArray(int number)
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i * number;
    }
    Console.WriteLine(string.Join(", ", array));
}
  public static void Main (string[] args){
    
    int number1 = int.Parse(Console.ReadLine());
    int number2 = int.Parse(Console.ReadLine());
    int sum = number1 + number2;
    FillArray(sum);
    

  }
}