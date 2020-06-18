using System;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args){
            int n,i;
            Console.WriteLine("Please enter the number of the List:");
            n = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("please enter List Numbers:");
            int[] Array = new int[n];
            for (i = 0; i < n; i++){
                Array[i]=Convert.ToInt32(Console.ReadLine()); 
            }
            BubbleSort.BubbleSortFirst(Array,n);//order n^2
            BubbleSort.BubbleSortSecond(Array,n);//order n
        }
    }
}