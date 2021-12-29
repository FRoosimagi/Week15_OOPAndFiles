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
            string gift;

            public SecretSanta(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
            }

            public string Name
            {
                get { return name; }
            }

            public string Gift
            {
                get { return gift; }
            }
        }

        static void Main(string[] args)
        {
            List<SecretSanta> mySecretSanta = new List<SecretSanta>();
            string[] giftFromFile = GetDataFromFile();

            foreach(string line in giftFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                SecretSanta newSecretSanta = new SecretSanta(tempArray[0], tempArray[1]);
                mySecretSanta.Add(newSecretSanta);
            }

            foreach(SecretSanta SecretSantaFromFile in mySecretSanta)
            {
                Console.WriteLine($"{SecretSantaFromFile.Name} wants {SecretSantaFromFile.Gift}");
            }
        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach(string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Dell\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
