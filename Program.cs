using System;

String [,] InputeString(int X_Length, int Y_Length)
{
    String [,] Array_String=new String[X_Length, Y_Length]; 
    for(int i=0; i<Y_Length; i++)
    {
        for(int j=0;j<X_Length;j++)
        {
            Console.Write($"Введите {j+1} слово в строке {i+1} :");
            Array_String[j,i]=Console.ReadLine();
        }
    }
    return Array_String;
}

void PrintArray (int X_Length, int Y_Length, String [,] Array_String)
{
    Console.Write("[");
    for(int j=0;j<Y_Length;j++)
    {
        Console.Write($"'{Array_String[j,X_Length]}'");
        if (j!=Y_Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("] -> ");
}

void ResultString(int X_Length, int Y_Length, String [,] Array_String)
{
    for(int i=0; i<Y_Length; i++)
    {
        PrintArray(i, X_Length, Array_String);
        Console.Write("[");
        for(int j=0;j<X_Length;j++)        
        {
            if (Array_String[j,i].Length<=3)
            {
                Console.Write($"'{Array_String[j,i]}'");
                if (j!=X_Length-1)
                {
                    Console.Write(", ");
                }
            }
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.Write("Введите количество слов в строке:");
int X_Length=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк:");
int Y_Length=Convert.ToInt32(Console.ReadLine());
ResultString(X_Length,Y_Length,InputeString(X_Length,Y_Length));