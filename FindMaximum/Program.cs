using System;
using FindMaximum;
class Program
{ public static void Main(String[] args)
    {
        Console.WriteLine(" ****** Welcome in the Priting Maximum Element Of the Array ****** ");
        bool check = true;
        Console.WriteLine(" Display Int Array Max Element 1\n Display float Array Max Element 2\n Display String Array Max Element 3\n");
        while (check)
        { 
        Console.WriteLine("Enter the Above Option");
            int option= Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    GenericMaximum<int> max = new GenericMaximum<int>();
                    int[] array = { 1, 5, 6, 7, 8, 9, 10 };
                    int actual = max.FindMaxElement(array);
                    Console.WriteLine("Maximum Element of Integer Array:->" + actual);
                    break;
               case 2:
                    GenericMaximum<float> maxFloat = new GenericMaximum<float>();
                    float[] float_Array = { 10.5f, 11.5f, 12.5f, 15.8f, 18.28f };
                    float actualFloat = maxFloat.FindMaxElement(float_Array);
                    Console.WriteLine("Maximum element os float Array:->" + actualFloat);
                    break;
                case 3:
                    GenericMaximum<string> mxaString = new GenericMaximum<string>();
                    string[] string_Array = { "Peach", "Apple", "Banana", "Mango", "PineApple", "Graps" };
                    string actual_String = mxaString.FindMaxElement(string_Array);
                    Console.WriteLine("Maximum element os string Array:->" + actual_String);
                    break;
                case 0:
                    check = false;
                    break;
            }
        }
    }
}