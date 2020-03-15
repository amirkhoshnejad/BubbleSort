using System;

namespace Bubble_Sort
{
    class Program
    {
        static void BubbleSortFirst(int[] Array,int n){
            int m,i,j;
            for(i=n-2;i>=0;i--){
                for(j=0;j<=i;j++){
                    if(Array[j]>=Array[j+1]){
                        m=Array[j];
                        Array[j]=Array[j+1];
                        Array[j+1]=m;
                    }
                }
            }
            Console.Write("your answer is:");
            for(i=0;i<n;i++){
                Console.Write(Array[i]+"/");
            }
        }
        static void BubbleSortSecond(int[] Array,int n){
            int i,j,m,z;            
            for(i=n-2;i>=0;i--){
                z=0;
                for(j=0;j<=i;j++){
                    if(Array[j]>=Array[j+1]){
                        m=Array[j];
                        Array[j]=Array[j+1];
                        Array[j+1]=m;
                        z++;
                    }
                }
                if(z==0){
                        break;}
            }
            for(i=0;i<n;i++){
                Console.Write(Array[i]+"/");
            }
        }
        static void Main(string[] args){
            int n,i;
            Console.WriteLine("Please enter the number of the List:");
            n = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("please enter List Numbers:");
            int[] Array = new int[n];
            for (i = 0; i < n; i++){
                Array[i]=Convert.ToInt32(Console.ReadLine()); 
            }
            BubbleSortFirst(Array,n);//order n^2
            BubbleSortSecond(Array,n);//order n
        }
    }
}
