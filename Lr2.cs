using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {

        static void Main(string[] args)
        {
            // Задание 1
            // пункт 1а
            int a = 2;
            double b = 2.22;
            bool c;
            c = true;
            long d = 10;
            char e = 'e';
            float f = 5.5f;
            string g = "Anton";
            // пункт 1b
            byte x = 10;
            Int16 w = x;
            Int32 y = x;
            Int64 z = y;
            double q = z;
            int r = w; //конец неявных преобразований

            byte h = 15;
            Int16 l = (Int16)h;
            Int32 t = (Int32)h;
            Int64 n = (Int64)t;
            double m = (double)n;
            int u = (int)n;
            // пункт 1c
            int one = 4;
            Object two = one; // упаковка, где two ссылается на упакованый объект one
            double three = (double)(int)two; //распаковка
            // пункт 1d
            var s = 4;
            // пункт 1e
            int? v = null;
            int? p = null;
            Double? s1 = 3.3;//или можно записать иначе==>
            Nullable<int> v1 = null;
            Nullable<int> p1 = null;
            Nullable<System.Double> s2 = 3.4;
            Console.WriteLine(v == p);


            // Задание 2

            // пункт 2a
            string fam = "karpach";
            string im = "anton";
            Console.WriteLine(fam == im);
            // пункт 2b
            string kar = fam.Substring(3, 4); //извлечение подстроки
            Console.WriteLine(kar);
            string[] many = { "Mash", "ka", };
            string many1 = string.Join(null, many); //сцепляет строку null это разделитель
            string cop = String.Copy(im);// copy
            Console.WriteLine(cop);// end
            string str1 = "resuld before copy";// copy
            string str2 = "resuld after copy";
            Console.WriteLine("1) str1 = '{0}'", str1);
            Console.WriteLine($"2) str2 = '{str2}'");
            Console.WriteLine("Copy... (str2 in to str1)");
            str2 = String.Copy(str1);
            Console.WriteLine("3) str1 = '{0}'", str1);
            Console.WriteLine("4) str2 = '{0}'", str2);//end
            String original = "aaabbbссс";//вставка подстроки еще используем при разделении сток этот метод
            Console.WriteLine("The original string: '{0}'", original);
            String modified = original.Insert(3, " ").Insert(7, " ");
            Console.WriteLine("The modified string: '{0}'", modified);//конец
            string si = "abc---def";// delite from the line
            Console.WriteLine("1)     {0}", si);
            Console.WriteLine("2)     {0}", si.Remove(3));
            Console.WriteLine("3)     {0}", si.Remove(3, 3));
            Console.WriteLine("Hello, world!");//end
            // пункт 2c
            string pust = "";
            string nulla = null;
            Console.WriteLine(pust == nulla);
            Console.WriteLine("This{0}dont't{0}worked", String.Concat(pust, nulla));
            // пункт 2d
            StringBuilder strb = new StringBuilder("Kar", 25);
            Console.WriteLine(strb);
            strb.Append("pach");                                 // добавление в конец
            strb.Insert(0, "Anton ");                               // добавление в начало  0 - позиция
            Console.WriteLine(strb);
            strb.Remove(6, 3);
            Console.WriteLine(strb);


            // Задание 3

            // пункт 3a
            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j]);
                }
                Console.WriteLine();
            }

            // пункт 3b
            string[] smas = { "one", "two", "three", "four", "five" };
            foreach (string x1 in smas)
                Console.Write(x1 + " ");
            Console.WriteLine();
            Console.WriteLine(smas.Length);
            Console.Write("Vvedite slovo iz massiva dlya zameny from the array:");
            string za = Console.ReadLine();
            Console.Write("Vvedite slovo dlya zameny:");
            string zam = Console.ReadLine();
            foreach (string x1 in smas)
                Console.Write(x1.Replace(za, zam) + " ");
            Console.WriteLine();
            // пункт 3c!!!!!!!!!!!!!!!!!!!!!!!!!1
            double[][] stmas = {
                new double[2],
                new double[3],
                new double[4]
            };


            for (int i11 = 0; i11 < stmas.Length; i11++)
            {
                for (int j = 0; j < stmas[i11].Length; j++)
                {

                    stmas[i11][j] = int.Parse(Console.ReadLine()); ////parse конвектирует значение любого типа в определенное }
                }
            }

            foreach (double[] sx in stmas)
            {
                foreach (double sy in sx)
                {
                    Console.Write("\t" + sy);
                }
                Console.WriteLine();

            }
            // пункт 4c
            var mass = new[] { 1, 2, 3 };                     // неявная типизация для хранения массива
            foreach (var i1 in mass)
            {
                Console.Write(i1);
            }
            Console.WriteLine();

            var masstr = new[] { "1a", "2b", "3c" };                     // неявная типизация для хранения строки
            foreach (var i1 in masstr)
            {
                Console.Write(i1);
            }
            Console.WriteLine();


            //Задание 4

            //пункт 4a,4b
            (int a1, string a2, char a3, string a4, ulong a5, int a6) name = (17, "avg", 'o', "ops", 15, 19);  // создание кортежа и именование при объявлении
            //пункт 4c
            Console.WriteLine(name.GetType().Name);
            Console.WriteLine($" {name}");// вывод кортежа                   
            Console.WriteLine(name.a1 + " " + name.a3 + " " + name.a4);// выборочный вывод
            // пункт 4e
            var t1 = ValueTuple.Create(17, "avg");
            var t2 = ValueTuple.Create(17, "avg");
            Console.WriteLine(t1.Equals(t2));
            // пункт 4d
            //var (first, second, thrird, four, five) = name;
            //Console.WriteLine(second);

            //Задание 5
            Tuple<double, double, double, char> local_function(double[] massiv, string temp)
            {
                double min, max;
                min = max = massiv[0];

                for (int step = 1; step < massiv.Length; step++)
                {
                    if (massiv[step] < min)
                    {
                        min = massiv[step];

                    }
                    else if (massiv[step] > max)
                    {
                        max = massiv[step];
                    }
                }
                double sum = min + max;
                char ch = ((char)temp[0]);
                return Tuple.Create<double, double, double, char>(max, min, sum, ch);
            }
            double[] elementi = { 1, 5, 2, 4, 0, 3, 7 };
            var new_tuple = local_function(elementi, "Anton");
            Console.WriteLine(new_tuple.Item3.ToString());

            Console.ReadKey();
        }

    }
   
}