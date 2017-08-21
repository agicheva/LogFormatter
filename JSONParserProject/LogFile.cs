using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JSONParserProject
{
    class LogFile
    {
        #region Private members
        //Contains the path to the .log file.
        private string _path;
        private string _fileContents;
        private string[] _rowsInLog;
        #endregion

        #region Public properties
        public string[] RowsInLog { get => _rowsInLog; set => _rowsInLog = value; }
        #endregion

        #region Constructor
        public LogFile(string path)
        {
            this._path = path;
            try
            {
                ReadLogFile();
                ListRowsFromLog();
            }
            catch (Exception)
            {
                throw new ArgumentException("Please provide valid log file path.");
            }
        }
        #endregion

        #region Helper methods
        /// <summary>
        /// Reads the file if the file does not exist, the function throws exception.
        /// </summary>
        /// <returns></returns>
        private void ReadLogFile()
        {
            this._fileContents = File.ReadAllText(this._path);
        }

        /// <summary>
        /// Lists the content of the file in array.
        /// </summary>
        private void ListRowsFromLog()
        {
            this.RowsInLog = this._fileContents.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
        }
        #endregion
    }
}
