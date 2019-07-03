using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //The first exercises
            Console.WriteLine("Write what you want to translate to bytes:");
            string s = Console.ReadLine();
            byte[] bytes = Encoding.UTF8.GetBytes(s);

            Console.WriteLine("Here are your text as bytes:");
            for (int i = 0; i < bytes.Length; i++)
            {
                Console.Write(bytes[i] + " ");
            }
            Console.WriteLine("");
            string reconverted = Encoding.UTF8.GetString(bytes);
            Console.WriteLine(reconverted);

            //Challenge bonus exercise
            MyASCII myASCII = new MyASCII();
            Console.WriteLine("Write what you want to translate to bytes:");
            string test = Console.ReadLine();
            byte[] myBytes = myASCII.fromStringToBytes(test);

            Console.WriteLine("Here are your text as bytes:");
            for (int i = 0; i < myBytes.Length; i++)
            {
                Console.Write(myBytes[i] + " ");
            }

            //Bonus exercise solved differently
            Console.WriteLine("Write what you want to translate to bytes:");
            string third = Console.ReadLine();
            char[] chars = new char[third.Length];
            byte[] arrayOfBytes = new byte[third.Length];

            for (int i = 0; i < third.Length; i++)
            {
                chars[i] = third[i];
            }
            for (int i = 0; i < third.Length; i++)
            {
                arrayOfBytes[i] = Convert.ToByte(chars[i]);
            }

            Console.WriteLine("Here are your text as bytes:");
            for (int i = 0; i < arrayOfBytes.Length; i++)
            {
                Console.Write(arrayOfBytes[i] + " ");
            }
        }
    }
}
