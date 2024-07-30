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

        static public int SumList(List<int> Numbers) {
          int Sum = 0;
            for (int i = 0; i < Numbers.Count; i++)
            {
                Sum += Numbers[i];
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

            #region Genric List
            //List<int> Numbers = new List<int>();
            //Console.WriteLine($"Count : {Numbers.Count}");
            //Console.WriteLine($"Capacity : {Numbers.Capacity}");
            //Numbers.Add(0);
            //Numbers.Add(1);
            //Numbers.AddRange([2, 6,4]);
            //Console.WriteLine($"Count : {Numbers.Count}");
            //Console.WriteLine($"Capacity : {Numbers.Capacity}");

            //Numbers.TrimExcess();
            //Console.WriteLine($"Count : {Numbers.Count}");
            //Console.WriteLine($"Capacity : {Numbers.Capacity}");

            //List<int> ints = new List<int>(5) { 1, 2, 3, 4 ,5};

            //for (int i = 0; i < ints.Count; i++)
            //{
            //    Console.WriteLine(ints[i]);
            //}

            //Numbers.EnsureCapacity(21);
            //for (int i = 6; i <= 21; i++)
            //{
            //    Numbers.Add(i);
            //}
            //Console.WriteLine($"Count : {Numbers.Count}");
            //Console.WriteLine($"Capacity : {Numbers.Capacity}");

            //Console.WriteLine(SumList(Numbers));

            #endregion


        }
    }
} 