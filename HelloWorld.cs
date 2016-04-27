using System;

public class HellowWorld
{
    public void Print()
    {
        Console.WriteLine("Hello World");
    }
    public void PrintMessage(string sMessage)
    {
        Console.WriteLine(sMessage);
    }
    public void PrintNumber(int nNumber)
    {
        Console.WriteLine(Convert.ToString(nNumber));
    }
    public void PrintDoubel(double dblNumber)
    {
        Console.WriteLine(Convert.ToString(dblNumber));
    }
    public void printFormattedMessage(string sMessage)
    {
        Console.WriteLine(sMessage);
    }
}

public class Calculator
{
    public int Add(int num1, int num2)
    {
        return num1 + num1;
    }
    public double Add(double num1, double num2)
    {
        return num1 + num1;
    }
}
