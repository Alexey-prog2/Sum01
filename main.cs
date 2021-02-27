using System;
    
public class Program
{
  static int SpSum(int a, int b)
  {
    int specialSum = a + b;

    if (specialSum >= 10 && specialSum <= 19){
      return 20;
    }

    return specialSum;
  }
    
  static void Main(string[] args)
  {
    int sumRes = SpSum(5, 2);
    Console.WriteLine("Result: {0}; expected: 7; successfully: {1}",sumRes, sumRes == 7);
    sumRes = SpSum(11, 10);
    Console.WriteLine("Result: {0}; expected: 21; successfully: {1}",sumRes, sumRes == 21);

    sumRes = SpSum(5, 5);
    Console.WriteLine("Result: {0}; expected: 20; successfully: {1}",sumRes, sumRes == 20);
  }

}