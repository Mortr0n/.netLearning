using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace multTable 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mTable = MTable(10);
            DrawTable(mTable);
        }

        public static int[,] MTable(int max)
        {
            int[,] table = new int[max, max];
            for(int row = 0; row < max; row++)
            {
                for(int col = 0; col < max; col++){
                    table[row,col] = (row + 1) * (col + 1);
                    Console.WriteLine(table[row,col]);
                }
            }
            return table;
        }

        public static void DrawTable(int[,] multArray)
        {
            StringBuilder sb = new StringBuilder();

            int length = multArray.GetLength(0);

            for(int row = 0; row < length; row++)
            {
                sb.Append("[");
                for(int col = 0; col < length; col++)
                {
                    sb.Append($"{multArray[row,col]}, ");
                }
                sb.Append("]\n");
            }
            Console.WriteLine(sb);
        }
        
    }
}