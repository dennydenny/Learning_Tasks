using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daniel_Khaliulin_Strings
{
    class StringHelper
    {
        private String _sentence;
        private int _averageWordLenght;
        /// <summary>
        /// Средняя длина слова в предложении.
        /// </summary>
        public int AverageWordLenght {
            get {return CalculateAverageWordLenght();}
            private set { _averageWordLenght = value; }
        }

        /// <summary>
        /// Инициализирует новый экземпляр StringHelper с текстом.
        /// </summary>
        /// <param name="text">Текст, в котором необходимо осуществить расчёт средней длины слова.</param>
        public StringHelper(String text)
        {
            if (String.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException("Text null or empty");
            }
            else
            {
                _sentence = text;
            }
        }

        private int CalculateAverageWordLenght()
        {
            if (!String.IsNullOrEmpty(_sentence))
            {
                String[] words = _sentence.Split(new char[] { ',', ' ', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
                int sentenseLenght = 0;
                foreach (String s in words)
                {
                    Console.WriteLine(s);
                    sentenseLenght += s.Length;
                }
                Console.WriteLine("sentenseLenght - {0} words.Length - {1}", sentenseLenght, words.Length);
                return AverageWordLenght = sentenseLenght / words.Length; ;
            }
            else 
            {
                throw new ArgumentNullException("Text null or empty");
            }
        }
    }
}
