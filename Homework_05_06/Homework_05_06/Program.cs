using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Threading.Tasks;

namespace Homework_05_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1
            double[] A = new double[5];
            double[,] B = new double[3, 4];

            double full_sum = 0;
            double full_mult = 1;
            double max = A[0];
            double min = A[0];
            double sum_even = 0;
            double sum_odd_columns = 0;
             
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"A[{i}] = ");
                A[i] = double.Parse(Console.ReadLine());
                full_sum += A[i];
                full_mult *= A[i];
                if (A[i] % 2 == 0) sum_even += A[i];
                if (max < A[i]) max = A[i];
            }

            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = rand.Next(0, 11);
                    full_sum += B[i,j];
                    full_mult *= B[i, j];
                    if (j % 2 == 0) sum_odd_columns+= B[i,j];
                }
            }
            Console.WriteLine("\nA:");
            foreach (double f in A) Console.Write($"{f} ");

            Console.WriteLine();
            Console.WriteLine("\nB:");

            for (int i = 0; i < 3; i++){
                for (int j = 0;j < 4; j++) Console.Write($"{B[i,j]} ");
                Console.WriteLine();
            }
            Console.WriteLine($"\n\nFull summary = {full_sum}, full multiply = {full_mult}, Summary of even numbers of array A = {sum_even}, summary of odd columns of Array B = {sum_odd_columns}, maximum and minimum is too hard =(");
            

            //TASK 2
            /*int[,] Array = new int[5, 5];
            Random rand = new Random();
            
            for (int i = 0; i < 5; i++){
                for (int j = 0; j < 5; j++)
                    Array[i, j] = rand.Next(-100, 101);
            }

            int min_i = 0;
            int min_j = 0;
            int max_i = 0;
            int max_j = 0;

            for (int i = 0; i < 5; i++){
                for (int j = 0; j < 5; j++){
                    if (Array[i, j] < Array[min_i, min_j]){
                        min_i = i; min_j = j;
                    }
                    if (Array[i, j] > Array[max_i, max_j]){
                        max_i = i; max_j = j;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write(Array[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Min is {Array[min_i, min_j]}, max is {Array[max_i, max_j]}");
            if (min_i > max_i){
                int temp = min_i;
                min_i = max_i;
                max_i = temp;
                int temp2 = min_j;
                min_j = max_j;
                max_j = temp2;
            }
            else if (min_i == max_i && min_j > max_j)
            {
                int temp = min_j;
                min_j = max_j;
                max_j = temp;
            }

            int sum = 0;
            for (int i = 0; i < 5; i++){
                for(int j = 0;j < 5; j++){
                    if (min_i * 5 + min_j < i * 5 + j && i * 5 + j < max_i * 5 + max_j)
                        sum+= Array[i,j];
                }
            }
            Console.WriteLine($"Sum of elements between minimum and maximum values: {sum}\n");*/

            //TASK 3
            /*Console.Write("Input your string: ");
            string input = Console.ReadLine();
            Console.Write("Enter the shiift(сдвиг): ");
            int shift = int.Parse(Console.ReadLine());

            string encrypted = Encrypt(input, shift);
            string decrypted = Decrypt(encrypted, shift);
            Console.WriteLine($"Encrypted string: {encrypted}");
            Console.WriteLine($"Decrypted string: {decrypted}");*/

            //TASK 5
            /*Console.Write("Enter your assignment: ");
            string assignment = Console.ReadLine();
            string[] strings;
            int result = 0;

            if (assignment.Contains('+'))
            {
                strings = assignment.Split('+');
                for (int i = 0; i < strings.Length; i++) result += int.Parse(strings[i]);
            }
            if (assignment.Contains('-'))
            {
                strings = assignment.Split('-');
                for (int i = 0; i < strings.Length; i++)
                {
                    if (i == 0)
                        result += int.Parse(strings[i]);
                    else
                        result -= int.Parse(strings[i]);

                }
            }
            Console.WriteLine(result);*/

            //TASK 7
            /*string text = "This is a test text with a prohibited word: c#. We will replace it. c#";
            Console.WriteLine($"Default text: {text}");
            List<string> prohibitedWords = new List<string>();
            bool _check = true;
            while (_check)
            {
                Console.WriteLine("Add a ban-word?\n1 - Yes\nAny other key - No\n");
                int select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Console.WriteLine("Enter ban-word: ");
                        prohibitedWords.Add(Console.ReadLine());
                        break;
                    default:
                        _check = false;
                        break;

                }
            }
            int replacementsMade = 0;
            foreach (string word in prohibitedWords)
            {
                int index = text.IndexOf(word);

                while (index != -1)
                {
                    text = text.Remove(index, word.Length).Insert(index, new string('*', word.Length));
                    replacementsMade++;
                    index = text.IndexOf(word, index + word.Length);
                }
            }
            Console.WriteLine($"Replacements made: {replacementsMade}");
            Console.WriteLine($"Modified text: {text}");*/
            }
            static string Encrypt(string input, int shift)
            {
                string result = "";
                foreach (char c in input)
                {
                    if (c >= 'a' && c <= 'z')
                    {
                        result += (char)(c + shift);
                    }
                    else if (c >= 'A' && c <= 'Z')
                    {
                        result += (char)(c + shift);
                    }
                    else
                    {
                        result += c;
                    }
                }
                return result;
            }
            static string Decrypt(string input, int shift)
            {
                string result = "";
                foreach (char c in input)
                {
                    if (c >= 'a' && c <= 'z')
                    {
                        result += (char)(c - shift);
                    }
                    else if (c >= 'A' && c <= 'Z')
                    {
                        result += (char)(c - shift);
                    }
                    else
                    {
                        result += c;
                    }
                }
                return result;
            }
        }
    }
