using System;
using System.Diagnostics;
namespace Assignment
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 15;
            printPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);


            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);


            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);


            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);
            Console.ReadLine();

            //I found the assignment challenging and a very good exrcise to refresh all the basic programming concepts.
            //Had a good practice of loops.

        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                Console.WriteLine("Prime numbers between " + x + " and " + y + " :");
                for( int i = x; i < y; i++)
                {
                    if (IsPrime(i))
                    {
                        Console.Write(i+" ");
                    }
                }
                Console.Write("\n");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        public static double getSeriesResult(int n)
        {
            try
            {
                double result = 0;
                for(int i = 1; i <= n; i ++)
                {
                    if (i % 2 == 0)
                    {
                        result -= getFactorial(i) / (i + 1);
                    }
                    else
                    {
                        result += getFactorial(i) / (i + 1);

                    }

                }
                return result;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }

        public static long decimalToBinary(long n)
        {
            try
            {
                string x = null;
                while (n>0)
                {
                    
                    long r = n % 2;
                    n = n / 2;
                    x = r.ToString() + x;
                }
                return Convert.ToInt64(x);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }

            return 0;
        }

        public static long binaryToDecimal(long n)
        {
            try
            {
                char[] arr = n.ToString().ToCharArray();
                int num = 0;
                for (int i = arr.Length-1; i >=0;i--)
                {
                    int a = Convert.ToInt32(Math.Pow(2, i));
                    int b = Convert.ToInt32(arr[i].ToString());
                   num += b * a ;
                }
                return num;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return 0;
        }

        public static void printTriangle(int n)
        {
            try
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = n - i; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                        for(int k = 1; k <=2*i+1; k++)
                        {
                            Console.Write("*");
                        }
                    
                        Console.WriteLine("");
                    }
            
                
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)
        {
            try
            {
                sortArray(a);
                int[] freqarr = new int[a.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    freqarr[i] = -1;
                }
                Console.WriteLine("Number" + "\t" + "Frequency");

                for (int i = 0; i < a.Length; i++)
                {

                    int count = 1;
                    for (int j = i + 1; j < a.Length; j++)
                    {

                        if (a[j] == a[i])
                        {
                            count += 1;
                            freqarr[j] = 0;
                        }
                    }
                    if (freqarr[i] != 0)
                    {
                        freqarr[i] = count;
                    }

                }

            
                for (int i = 0; i < a.Length; i++)
            {
                if (freqarr[i] != 0)
                {
                    Console.WriteLine(a[i] + "\t" + freqarr[i]);
                }
            }
        }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
        public static double getFactorial(int n)
        {
            double x = 1;
            for (double i = n; i > 0; i--)
            {
                x *= i;
            }
            return x;
        }
        public static int[] sortArray(int[] arr)
        {
            
            for(int i = 0; i < arr.Length; i++)
            {
                
                for(int j = i + 1; j < arr.Length ; j++)
                { 
                    if (arr[j] < arr[i])
                    {
                        int temp = 0;
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;


                    }
                    
                }
               
            }
            return arr;
        }
        public static Boolean IsPrime(int a)
        {
            if (a > 1)
            {
                int count = 0;
                for (int i = 2; i <= a / 2; i++)
                {
                    if (a % i == 0)
                    {
                        count = +1;
                    }
                }
                if (count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        
    }
}
