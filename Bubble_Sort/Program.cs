using System;

namespace Bubble_Sort
{
    class Program
    {
        static void BubbleSortFirst(){
            int i,j,m,n;
            n=10;
            int [] Array={4,5,8,9,3,6,2,7,1,0};
            for(i=n-2;i>=0;i--){
                for(j=0;j<=i;j++){
                    if(Array[j]>=Array[j+1]){
                        m=Array[j];
                        Array[j]=Array[j+1];
                        Array[j+1]=m;
                    }
                }
            }
            for(i=0;i<n;i++){
                Console.Write(Array[i]+"/");
            }
            Console.WriteLine("");
        }
        static void BubbleSortSecond(){
            int i,j,m,n=10,z;            
            int [] Array={4,5,8,9,3,6,2,7,1,0};
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
        static void Main(string[] args)
        {
            BubbleSortFirst();//order n^2
            BubbleSortSecond();//order n
        }
    }
}
