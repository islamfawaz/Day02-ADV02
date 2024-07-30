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

            #region List Method
            List<int> List = new List<int>();

            // List.Add(1);
            // List.AddRange([3,6]);
            // List.InsertRange(3, [ 5, 6, 7 ]);
            // List.Insert(3, 4);


            // IReadOnlyList<int> ReadOnlyNo = List.AsReadOnly();
            // for (int i = 0; i < List.Count; i++)
            //{
            //    Console.WriteLine(List[i]);
            //}


            #region BinarySearch
            //Console.WriteLine(List.BinarySearch(2));
            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee(10,"Islam",3232),
            //    new Employee(20,"Ahmed",5433),
            //    new Employee(30,"Fawaz",29435)
            //};
            //int index = employees.BinarySearch(new Employee() { salary = 29435 });
            //Console.WriteLine("index of employee : " + index);

            //int indexx = employees.BinarySearch(new Employee() { Name = "Ahmed" }, new EmployeeComparer());
            //Console.WriteLine("search by name : " + indexx);
            //int indexxx = employees.BinarySearch(1, 2, new Employee() { Name = "Ahmed" }, new EmployeeComparer());

            #endregion
            
            List.Clear();
            List.Contains(2);
            List<long> newNumber = List.ConvertAll<long>(N => N);
            List<long> newNo = List.Select<int, long>(N => (long)N).ToList();
            int[] arr= new int[5];
            List.CopyTo(arr);


           int even= List.Find(n => n % 2 == 0);
            int evenn = List.FindIndex(n=> n % 2 == 0);
            bool isExist = List.Exists(hambozo => hambozo % 2 == 0);
            List.TrueForAll(hambozo => hambozo % 2 == 0);

            Console.WriteLine(even);

            List.ForEach(hambozo => { hambozo += 100; });
            List.GetRange(2, 3);
            List.Slice(3, 4);
            List.IndexOf(3, 4);
            List.LastIndexOf(3, 4);
            List.RemoveAt(0);
            List.RemoveAll(n =>n>4);


            #endregion
        }
    }
} 