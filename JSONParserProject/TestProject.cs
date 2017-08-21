using System;

namespace JSONParserProject
{
    class TestProject
    {
        static void Main(string[] args)
        {
            LogFile r = new LogFile("C:/Users/i342648/Documents/work/trace_2017.07.20.15.51.55.044822.log");
            string[] rr = r.RowsInLog;

            for (int i = 0; i < rr.Length; i++)
            {
                Console.WriteLine(rr[i]);
            }
        }
    }
}