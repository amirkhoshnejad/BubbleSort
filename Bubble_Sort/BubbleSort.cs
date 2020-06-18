using System;

namespace Bubble_Sort
{
    public class BubbleSort
    {
        public static void BubbleSortFirst(int[] Array,int n){
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
        public static void BubbleSortSecond(int[] Array,int n){
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
    }
}
