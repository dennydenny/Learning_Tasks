using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приложение позволяет из введённого предложения выделить отдельные слова и для каждого посчитать частоту встречаемости.");
            Console.WriteLine("Пожалуйста, введите предложение (на английском):");
            String sentence = Console.ReadLine();

            string [] separators = new string [] {" ", "."};

            String [] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Dictionary <string, int> dict = new Dictionary<string, int>  ();

            foreach (string word in words)
            {
                int o;
                if (dict.TryGetValue(word, out o))
                {
                    dict[word] += 1; 
                }
                else
                {
                    dict.Add(word, 1);
                } 
            }
            foreach (KeyValuePair<string, int> kv in dict)
                Console.WriteLine("Key {0}; Value {1}", kv.Key, kv.Value);
            Console.ReadKey();

            }       
        }
    }

