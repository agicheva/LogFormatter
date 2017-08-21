using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace JSONParserProject
{
    class JsonParser
    {
        public string LogFile;

        public JsonParser(string logFile)
        {
            this.LogFile = logFile;
        }

        public string[] listRows()
        {
            string[] result = this.LogFile.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            return result;
        }

        public string[] splitRow(string row)
        {
            string[] splittedRow = row.Split(new string[] { ": "}, StringSplitOptions.None);

            return splittedRow;
        }

        public bool isResponseJson(string response)
        {
            if (response.StartsWith("{"))
            {
                return true;
            }
            return false;
        }
    }
}
