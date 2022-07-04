using System;

namespace Myproject9
{
    class Array1
    {

        static void Main(string[] args)
        {
            string[] Employee = { "Ashu", "jay", "Vijay", "Shree", "Ganesh", "Ram", "Seeta", "Neetu", "Rohit", "kavy", "Shital", "Harish" };

            for (int i = 0; i < Employee.Length - 10; i++)
            {
                Console.WriteLine("data1" + Employee[i]);
            }
            for (int i = 5; i < Employee.Length - 5; i++)
            {
                Console.WriteLine("data2" + Employee[i]);
            }
            for (int i = 10; i < Employee.Length; i++)
            {
                Console.WriteLine("data3" + Employee[i]);
            }

        }
    }
    class foreachreve
    {
        static void Main()
        {
            string[] Users = { " Sumit", "Amit", "moni", "jatin", "boby" };
            Console.WriteLine("List Display");
            for (int i = 0; i < Users.Length; i++)
            {
                Console.WriteLine(Users[i]);
            }
            Array.Sort(Users);
            Console.WriteLine("order List Display");
            for (int i = 0; i < Users.Length; i++)
            {
                Console.WriteLine(Users[i]);
            }
            Array.Reverse(Users);
            Console.WriteLine("Desc order List Display");
            for (int i = 0; i < Users.Length; i++)
            {
                Console.WriteLine(Users[i]);
            }
        }
    }

    class Arrays2
    {
        static void Main(string[] args)
        {
            string[] name = { "Rahul", "Mohit", "Naman", "Aditi", "Roshani", "Abhay" };
            int count = 0;


            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < name[i].Length; j++)
                {
                    count++;
                }
                Console.WriteLine(name[i] + ":" + count);
            }

        }
    }
    class Arrevenelement
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 7, 3, 8, 2 };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
    class Arreverse
    {
        static void Main(string[] args)
        {
            char[] ch = new char[5];
            Console.WriteLine("enter char");
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());

            }
            Console.WriteLine(".....");
            Console.WriteLine(string.Join(" ", ch));
            Console.WriteLine("//////");
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                Console.Write(ch[i] + " ");
            }

        }
    }
    class Arrmaxelement
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 4, 6, 8, 1 };
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];

                }
            }
            Console.WriteLine("max=" + max);
        }
    }
    class Reversearray
    {
        static void Main(string[] args)
        {
            int[] a = { 6, 7, 4, 2, 3 };
            Console.WriteLine(string.Join(" ", a));
            int j = a.Length - 1;
            for (int i = 0; i < a.Length / 2; i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;

            }
            Console.WriteLine("///////");
            Console.WriteLine(string.Join(" ", a));
        }
    }
    class Arrpresentornot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array elements");
            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine("enter the number for search");
            int num = int.Parse(Console.ReadLine());
            bool isPresent = false;

            for (int i = 0; i < a.Length; i++)
            {
                if (num == a[i])
                {
                    isPresent = true;
                    break;

                }
            }
            if (isPresent == true)
            {
                Console.WriteLine("element is present");

            }
            else
            {
                Console.WriteLine("not present");
            }
        }
    }
    class Sumofevennumarr
    {
        static void Main(string[] args)
        {
            int[] a = { 50, 34, 56, 13, 66, 34, 55 };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum = sum + a[i];

                }

            }
            Console.WriteLine("sum of even element in array=" + sum);
        }
    }
    class Sumofarrele
    {
        static void Main(string[] args)
        {
            int[] a = { 50, 34, 56, 13, 66, 34, 55 };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("sum of array=" + sum);
        }
    }
    class MinofInteger
    {
        static void Main(string[] args)
        {
            int[] a = { 55, 66, 56, 45, 75, 25, 21 };
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];

                }
            }
            Console.WriteLine("Min integer=" + min);

        }
    }
    class MinofCharacter
    {
        static void Main(string[] args)
        {
            char[] a = { 'k', 'y', 't', 'g', 'f' };
            char min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];

                }
            }
            Console.WriteLine("Min char=" + min);

        }
    }
    class Reversechar
    {
        static void Main(string[] args)
        {
            char[] a = { 'k', 'y', 't', 'g', 'f' };
            Console.WriteLine(string.Join(" ", a));
            int j = a.Length - 1;
            for (int i = 0; i < a.Length / 2; i++)
            {
                char temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;

            }
            Console.WriteLine(string.Join("", a));
        }
    }
    class Alterarray
    {
        static void Main(string[] args)
        {

            int[] a = { 55, 225, 36, 223, 114, 225, 554 };
            Console.WriteLine(string.Join(" ", a));
            for (int i = 0; i < a.Length; i = i + 2)
            {
                Console.WriteLine(a[i] + " ");

            }

        }
    }
    class Sumofprimearrays
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 225, 6, 223, 11, 225, 554 };
            Console.WriteLine(string.Join(" ", a));
            int sum = 0;
            Console.WriteLine("prime num in array are :");
            for (int i = 0; i < a.Length; i++)
            {
                int n = a[i];
                bool isprime = true;
                for (int j = 2; j < n; j++)
                {
                    if (n % j == 0)
                    {
                        isprime = false;
                        break;

                    }
                }
                if (isprime == true)
                {
                    Console.WriteLine(a[i]);
                    sum = sum + n;
                }

            }
            Console.WriteLine("sum of prime num=" + sum);

        }
    }
    class Evenfromarray5
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 4, 5, 6, 7, 11 };
            for (int i = 0; i < a.Length; i++)
            {

                int n = a[i];
                bool isprime = true;
                for (int j = 2; j < n; j++)
                {
                    if (n % j == 0)
                    {
                        isprime = false;
                    }
                }
                if (isprime == true)
                {
                    Console.WriteLine("Prime Num" + a[i]);
                }


            }
        }
    }
    class Pyramidpatt
    {

        static void Main(string[] args)
        {
            for (int r = 5; r >= 1; r--)
            {
                for (int space = 1; space <= 5 - r; space++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(r);
                }
                Console.WriteLine();
            }
        }
    }
    class Coprimepro
    {
        public static void isCoprime(int n)
        {
            int gcd = 0;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (n % j == 0 && i % j == 0)
                        gcd = j;

                }
                if (gcd == 1)
                    count++;
            }
            Console.WriteLine(count);

        }
        static void Main(string[] args)
        {

            Coprimepro.isCoprime(4);
        }
    }
    class Arithe
    {
        static void Main(string[] args)
        {
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());
            int d = a3 - a2;
            for (int i = 4; i <= n; i++)
            {
                a3 = a3 + d;
            }
            Console.WriteLine(a3);
        }
    }
}


