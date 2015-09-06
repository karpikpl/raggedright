using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using KattisSolution.IO;

namespace KattisSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Solve(Console.OpenStandardInput(), Console.OpenStandardOutput());
        }

        public static void Solve(Stream stdin, Stream stdout)
        {
            var scanner = new StreamReader(stdin);
            // uncomment when you need more advanced reader
            //scanner = new Scanner(stdin);
            BufferedStdoutWriter writer = new BufferedStdoutWriter(stdout);

            LinkedList<int> lines = new LinkedList<int>();
            int n = 0;

            while (!scanner.EndOfStream)
            {
                var len = scanner.ReadLine().Length;

                if (n < len)
                    n = len;

                lines.AddLast(len);
            }

            lines.RemoveLast();

            var result = lines.Select(m => (n - m) * (n - m)).Sum(m => m);

            writer.Write(result);
            writer.Write("\n");
            writer.Flush();
        }
    }
}