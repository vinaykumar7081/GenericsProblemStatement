using System;
using GenericsProjectStatement;
class Program
{
    public static void Main(String[] args)
    { 
    PrintingArrayElement arr=new PrintingArrayElement();
        float[] floatArray = { 10.5f,15.2f,0.0005f,-1.25f };
        arr.Maximumelement(floatArray);
    }
}