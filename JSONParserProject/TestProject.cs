using System;

namespace JSONParserProject
{
    class TestProject
    {
        static void Main(string[] args)
        {
            LogFile r = new LogFile("C:/Users/i342648/Documents/work/trace_2017.07.20.15.51.55.044822.log");
            string res = r.ReadLogFile();

            JsonParser jp = new JsonParser(res);
            string[] rr = jp.listRows();
            string row = rr[3];
            string[] words = jp.splitRow(row);

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            Console.WriteLine(jp.isResponseJson(words[1]));
            
        }
    }
}