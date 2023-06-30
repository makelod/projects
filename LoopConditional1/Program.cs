using System;
public class LoopConditional1
{
    public static void Main()
    {
        int col1, col2;

  
        Console.Write("Find the quadrant where the coordinates are located:\n");
        

        Console.Write("Input the value for X coordinate :");
        col1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the value for Y coordinate :");
        col2 = Convert.ToInt32(Console.ReadLine());


        if (col1 > 0 && col2 > 0)
            Console.Write("The coordinate point ({0} {1}) lies in the   1st quandrant.\n\n", col1, col2);
        else if (col1 < 0 && col2 > 0)
            Console.Write("The coordinate point ({0} {1}) lies in the 2nd quandrant.\n\n", col1, col2);
        else if (col1 < 0 && col2 < 0)
            Console.Write("The coordinate point ({0} {1}) lies in the 3rd quandrant.\n\n", col1, col2);
        else if (col1 > 0 && col2 < 0)
            Console.Write("The coordinate point ({0} {1}) lies in the 4th quandrant.\n\n", col1, col2);
        else if (col1 == 0 && col2 == 0)
            Console.Write("The coordinate point ({0} {1}) lies at the origin.\n\n", col1, col2);

    }
}