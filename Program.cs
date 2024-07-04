using System;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Buffers.Text;
using System.Text;

namespace MyApp
{
    internal class Program
    {
        public static void swap_value_by_value(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        public static void swap_value_by_ref(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        public static void swap_ref_by_value(int[]arr)
        {
            int c = arr[0];
            arr[0] = arr[1];
            arr[1] = c;
        }
        public static void swap_ref_by_ref(ref int[] arr)
        {
            int c = arr[0];
            arr[0] = arr[1];
            arr[1] = c;
        }
        public static void sum_and_sub(int a,int b,int c,int d,out int sum,out int sub)
        {
            sum = a + b + c + d;
            sub = a - b - c - d;
        }
        public static int sum_of_digit_of_number (int num)
        {
            int ans = 0;
            while(num > 0)
            {
                ans += (num % 10);
                num /= 10;
            }
            return ans;
        }
        public static bool IsPrime(int num)
        {
            for(int i = 2; i * i <= num; i++)
                if(num%i == 0) return false;

            return true;
        }
        public static void MinMaxArray(ref int[] arr,out int min,out int max) { 
            max = 0; min = int.MaxValue;
            foreach(int i in arr)
            {
                if(i < min) min = i;
                if(i > max) max = i;
            }
        }
        public static int fact(int n)
        {
            int ans = 1;
            for (int i = 2; i <= n; i++) ans *= i;
            return ans;
        }
        public static void change_char_in_string(ref StringBuilder str,int i,char c)
        {
            if (i < str?.Length)
            {
                str[i] = c;
            }
        }
        static void Main(string[] args)
        {
            //1- Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example.
            //Passing by value : this will make a copy of the parameters and any effect will done to the parameters will effect only he copy
            //Passing by reference : this will pass the original parameters and any effect will done to the parameters will effect the original parameters
            //int a = 5, b = 10;
            //swap_value_by_value(a, b);
            //swap_value_by_ref(ref a, ref b);

            //2- Explain the difference between passing(Reference type parameters) by value and by reference then write a suitable c# example.
            //Passing by Value: This will pass a copy of the reference to the object so any modifications will affect the object itself but not the reference
            //Passing by Reference: This will pass the reference to the reference itself allowing changes to both the object and the reference
            //int[] arr = { 1, 2 };
            //Console.WriteLine(arr[0] + " " + arr[1]);
            //swap_ref_by_value(arr);
            //Console.WriteLine(arr[0] + " " + arr[1]);
            //Console.WriteLine('-'*50);
            //Console.WriteLine(arr[0] + " " + arr[1]);
            //swap_ref_by_ref(ref arr);
            //Console.WriteLine(arr[0] + " " + arr[1]);

            //3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int sum = 0, sub = 0;
            //q3(1, 2, 3, 4,out sum,out sub);
            //Console.WriteLine(sum + " " + sub);

            //4- Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.Output should be like Enter a number: 25 The sum of the digits of the number 25 is: 7 
            //Console.WriteLine(sum_of_digit_of_number(12345));

            //5- Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.WriteLine(IsPrime(24));

            //6- Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] arr = {5,88,13,46,79,165};
            //int min,max;
            //MinMaxArray(ref arr,out min,out max);
            //Console.WriteLine(min + " " + max);

            //7- Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //Console.WriteLine(fact(5));

            //8- Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
            //StringBuilder str = new StringBuilder ("Man");
            //Console.WriteLine(str);
            //change_char_in_string(ref str, 0, 'C');
            //Console.WriteLine(str);
        }
    }
}