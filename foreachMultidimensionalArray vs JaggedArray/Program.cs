using System;

//ref link:https://www.youtube.com/watch?v=T0Zg7kQ3RVE&list=PLRwVmtr-pp07QlmssL4igw1rnrttJXerL&index=5
// jagged array -- multiple arrays with different length
// rectangular array -- multiple arrays with same length
// multidimension array -- [,]1d , [,,]2d , [,,,]3d , [,,,,]4d .....

class MainClass
{
    static void Main()
    {       
        int[][] partiesJagged = new int[3][];   
        partiesJagged[0] = new[] { 25, 27, 23, 34, 36, 99 };
        partiesJagged[1] = new[] { 25, 27, 23, 34, 36, 99, 101, 99 };
        partiesJagged[2] = new[] { 25, 27, 23, 34, 36, 99 };
        int[,] partiesMultidimensional = new int[3, 6]  
        {
            { 25, 27, 23, 34, 36, 99 },
            { 25, 27, 23, 34, 36, 99 },
            { 25, 27, 23, 34, 36, 99 }
        };
        //int[] partiesMultidimensional = new int[18]
        //{
        //     25, 27, 23, 34, 36, 99 ,
        //     25, 27, 23, 34, 36, 99 ,
        //     25, 27, 23, 34, 36, 99 ,
        //};
        /*for (int i = 0; i < partiesJagged.Length; i++)
        { 
            for (int j = 0; j < partiesJagged[i].Length; j++)
                Console.Write(partiesJagged[i][j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < partiesMultidimensional.GetLength(0); i++)
        {
            for (int j = 0; j < partiesMultidimensional.GetLength(1); j++)
                Console.Write(partiesMultidimensional[i, j] + " ");
            Console.WriteLine();
        }*/
        foreach (int[] thisRow in partiesJagged)
        { 
            foreach(int i in thisRow)
                Console.Write(i + " ");
            Console.WriteLine();
        }
        foreach (int i in partiesMultidimensional)
            Console.WriteLine(i);
    }
}