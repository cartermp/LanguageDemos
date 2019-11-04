using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    /// <summary>
    /// Using declarations - declare disposable variables as variables, not weird blocky-things!
    /// </summary>
    public class UsingDeclarations
    {
        public static int WriteLinesToFile(IEnumerable<string> lines)
        {
            using var file = new System.IO.StreamWriter("WriteLines2.txt");
            // Notice how we declare skippedLines after the using statement.
            int skippedLines = 0;
            foreach (string line in lines)
            {
                if (!line.Contains("Second"))
                {
                    file.WriteLine(line);
                }
                else
                {
                    skippedLines++;
                }
            }
            // Notice how skippedLines is in scope here.
            return skippedLines;
            // file is disposed here
        }
    }
}
