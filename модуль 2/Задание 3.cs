using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace модуль_2
{
    /*Задание 3
    Пользователь вводит строку с клавиатуры. 
    Необходимо зашифровать данную строку используя шифр Цезаря.
    Кроме механизма шифровки, реализуйте механизм расшифрования.*/
    internal class Задание_3
    {
        static void Main(string[] args)
        {
            //работает с англ.раскладкой, если русс. раскладку не расшифровывает
            Console.Write("Введите строку для шифрования: ");
            string text = Console.ReadLine();

            Console.Write("Введите сдвиг: ");
            int shift = int.Parse(Console.ReadLine());

            string encrypted = Caesar(text, shift, true);
            string decrypted = Caesar(encrypted, shift, false);

            Console.WriteLine($"\nЗашифрованная строка: {encrypted}\nРасшифрованная строка: {decrypted}");
        }
        //метод шифр Цезаря принимает строку, сдвиг и (true - шифровать или false - расшифровать)
        static string Caesar(string text, int shift, bool encrypt)
        {
            string result = "";
            if (encrypt) shift = -shift;

            foreach (char c in text)
            {
                if (!char.IsLetter(c))
                {
                    result += c;
                    continue;
                }
                int charCount = (int)c + shift;
                if (char.IsLower(c) && charCount < 97)
                {
                    charCount += 26;
                }
                else if (char.IsUpper(c) && charCount < 65)
                {
                    charCount += 26;
                }
                else if (char.IsLower(c) && charCount > 122)
                {
                    charCount -= 26;
                }
                else if (char.IsUpper(c) && charCount > 90)
                {
                    charCount -= 26;
                }

                result += (char)charCount;
            }

            return result;
        }
    }
}
