using System;
using GenericsProjectStatement;
class Program
{
    public static void Main(String[] args)
    { 
    PrintingArrayElement arr=new PrintingArrayElement();
        int[] intArray = { 1,2,4,58,7,5,54,55489,5894 };
        float[] floatArray = { 10.5f, 15.2f, 0.0005f, -1.25f };
        string[] stringArray = { "abc", "abcd", "abcde", "abcef" };
        arr.Maximumelement<int>(intArray);
        arr.Maximumelement<float>(floatArray);
        arr.Maximumelement<string>(stringArray);
    }
}