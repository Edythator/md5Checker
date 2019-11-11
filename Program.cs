//What are you doing here?
using System;
using System.Security.Cryptography;
using System.IO;

namespace md5Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "";

            if (args.Length == 0)
            {
                Console.WriteLine("Which file would you like to calculate the MD5/SHA1/CRC32 hash of?");
                path = Console.ReadLine();
            }

            else
            {
                path = args[0];
            }

            byte[] input = File.ReadAllBytes(path);

            MD5 md5 = MD5.Create();
            SHA1 sha1 = SHA1.Create();

            Console.WriteLine("\nMD5: " + BitConverter.ToString(md5.ComputeHash(input)).Replace("-", "") 
                + "\nSHA1: " + BitConverter.ToString(sha1.ComputeHash(input)).Replace("-", "") 
                + "\nCRC32: " + Crc32.Compute(input));

            Console.ReadLine();
        }
    }
}
