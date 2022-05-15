using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class SecretSanta
        {
            string name;
            string wish;

            public SecretSanta(string _name, string _wish)
            {
                name = _name;
                wish = _wish;
            }

            public string Name
            {
                get
                {
                    return name;
                }
            }
            public string Wish
            {
                get
                {
                    return wish;
                }
            }
        }

        static void Main(string[] args)
        {
            List<SecretSanta> mySecretSanta = new List<SecretSanta>();
            string[] childrenFromFile = GetDataFromFile();

            foreach (string line in childrenFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

                SecretSanta newSanta = new SecretSanta(tempArray[0], tempArray[1]);

                mySecretSanta.Add(newSanta);
            }
            foreach (SecretSanta childrenFromList in mySecretSanta)
            {
                Console.WriteLine($"{childrenFromList.Name} wants {childrenFromList.Wish}");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"D:\visual_studio_failid\samples\Frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }

    }
}
