using System.Collections;

namespace Demo
{
    internal class Program
    {

      static public int Sum(ArrayList Numbers)
        {
            int Sum = 0;
            if (Numbers is not null)
            {
                for (int i = 0; i < Numbers.Count; i++)
                {
                    Sum += (int?)Numbers[i] ?? 0;
                }
            }

            return Sum;
        }
        
        static void Main(string[] args)
        {
            #region ArrayList
            //ArrayList Numbers = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ////Numbers.Add(1);
            ////Numbers.Add(2);
            ////Numbers.Add(3);
            ////Numbers.Add(4);
            ////Numbers.Add(5);
            //Console.WriteLine("Count : " + Numbers.Count);
            //Console.WriteLine("Capacity : " + Numbers.Capacity);

            //Numbers.TrimToSize();
            //Console.WriteLine("Count : " + Numbers.Count);
            //Console.WriteLine("Capacity : " + Numbers.Capacity);

            //for (int i = 0; i < Numbers.Count; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            #endregion
            #region NonGenric Cons
            //Console.WriteLine(Sum(Numbers)); 
            #endregion

        }
    }
} 