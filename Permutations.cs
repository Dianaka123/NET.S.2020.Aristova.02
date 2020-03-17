using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NET.S._2020.Aristova._02
{
    public class Permutations
    {
        //Список перестановок
        private List<int> _permutationsList;
        private String _str;

        /// <summary>
        /// Добавляет новую перестановку в список
        /// </summary>
        /// <param name="a">Массив символов
        /// <param name="repeat">Содержать повторы
        private void AddToList(char[] a, bool repeat = true)
        {
            var bufer = new StringBuilder("");
            for (int i = 0; i < a.Count(); i++)
            {
                bufer.Append(a[i]);
            }
            if (repeat || !_permutationsList.Contains(int.Parse(bufer.ToString())))
            {
                _permutationsList.Add(int.Parse(bufer.ToString()));
            }

        }

        /// <summary>
        /// Рекурсивный поиск всех перестановок
        /// </summary>
        /// <param name="a">
        /// <param name="n">
        /// <param name="repeat">Содержать повторы
        private void RecPermutation(char[] a, int n, bool repeat = false)
        {
            for (var i = 0; i < n; i++)
            {
                var temp = a[n - 1];
                for (var j = n - 1; j > 0; j--)
                {
                    a[j] = a[j - 1];
                }
                a[0] = temp;
                if (i < n - 1) AddToList(a, repeat);
                if (n > 0) RecPermutation(a, n - 1, repeat);
            }
        }

        public Permutations()
        {
            _str = "";
        }

        public Permutations(String str)
        {
            _str = str;
        }
        /// <summary>
        /// Строка, на основе которой строятся перестановки
        /// </summary>
        public String PermutationStr
        {
            get
            {
                return _str;
            }
            set
            {
                _str = value;
            }
        }
        /// <summary>
        /// Получает список всех перестановок
        /// </summary>
        /// <param name="repeat">Содержать повторения
        /// <returns></returns>
        public List<int> GetPermutationsList(bool repeat = false)
        {
            _permutationsList = new List<int> { int.Parse(_str) };
            RecPermutation(_str.ToArray(), _str.Length, repeat);
            return _permutationsList;
        }
        
    }

}
