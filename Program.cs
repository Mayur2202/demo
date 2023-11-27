using System;
using System.Diagnostics;

class program3
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a first no:");
        string a = Console.ReadLine();
        Console.Write("Enter a second no:");
        string b = Console.ReadLine();
        double ac = Convert.ToDouble(a);
        double bc = Convert.ToDouble(b);
        Console.WriteLine("To press 1 for addition.");
        Console.WriteLine("To press 2 for subtraction.");
        Console.WriteLine("To press 3 for Multiplication.");
        Console.WriteLine("To press 4 for divide.");
        Console.WriteLine("To press 5 for mod or Remainder.");
        Console.Write("Enter your decision no:");
        int d=int.Parse(Console.ReadLine()) ;
        double Result = 0;
        switch(d)
        {
            case 1:
                Result = ac + bc;
                break;
            case 2:
                Result = ac - bc;
                break;
            case 3:
                Result = ac * bc;
                break;
            case 4:
                if (bc==0)
                {
                    Console.WriteLine(ac +" "+"is Cannot divide 0");
                    return;
                }
                Result = ac / bc;
                break;
            case 5:
                Result = ac % bc;
                break;

        }
        Console.WriteLine("The Calculation is:" + Result);
        Console.ReadLine();
        

    }
}