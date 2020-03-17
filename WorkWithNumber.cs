using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace NET.S._2020.Aristova._02
{
    class WorkWithNumber
    {
        public static int InsertNumber(int numberSource, int numberIn, int i, int j)
        {
            if (i > j || i < 0 || j < 0)//check valid data
            {
                throw new ArgumentOutOfRangeException();
            }

            int newNum = 0;
            if (i <= j)
            {
                int pow = j - i; // power for 2
                int insertIndex = i;
                int num = (int)Math.Pow(2, pow) - 1; // число для сохранения кол-ва бит numIn начиная сконца
                
                if (i == j)
                {
                    insertIndex = i;
                    num = (int)Math.Pow(2, pow); 
                }
                

                numberIn = num & numberIn; // создаём новое число, в котором сохранено нужное кол-во бит
                numberIn <<= insertIndex; // передвинаем на нужное место

            }
            return numberSource|numberIn; 
        }

        public static Stopwatch stopWatch; // таймер
        
        public static int FindNextBiggerNumber(int num)
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();

            string str = num.ToString(); 
            var per = new Permutations(str); // перевменная класса для создания вариаций перестановок
            var list = per.GetPermutationsList(); // получаем список всех возможных перестановок

            return FoundMax(list, num);
        }

        private static int FoundMax(List<int> listOfPermutations, int num)
        {
            List<int> elementsMoreThenNum = new List<int>();
            foreach (var elem in listOfPermutations)
            {
                
                if (elem > num)
                {
                    elementsMoreThenNum.Add( elem); // добавляем числа больше данного числа
                }
            }

            if (elementsMoreThenNum.Count == 0)
            {
                return -1;
            }
            else
            {
                return SearchMin(elementsMoreThenNum);
            }
        }

        private static int SearchMin(List<int> listNum)
        {
            int min = int.MaxValue;
            
            for (int i = 0; i < listNum.Count; i++)
            {
                if (listNum[i] < min)
                {
                    min = listNum[i];
                }

            }
            stopWatch.Stop();
            return min;
        }



        public static List<int> FilterDigit(int[] array, int FilterNum)
        {
            CheckNull(array);
            List<int> filters = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].ToString().Contains(FilterNum.ToString())) 
                {
                    filters.Add(array[i]);
                }
            }

            return filters;
        }


        public static double FindNthRoot(double n, double A, double eps = 0.0001)
        {
            
            var x0 = A / n;
            var x1 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, (int)n - 1));

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, (int)n - 1));
            }

            return x1;

        }


        private static void CheckNull(Object obj)
        {
            if (obj == null)
            {
                throw new NullReferenceException(); 
            }
        }
    }
}
