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
        #endregion

        #region Constructor
        public LogFile(string path)
        {
            this.Path = path;
            try
            {
                ReadLogFile();
            }
            catch (Exception)
            {
                throw new ArgumentException("Please provide valid log file path.");
            }
        }
        #endregion

        #region Public properties
        public string Path { get => _path; set => _path = value; }
        public string FileContents { get => _fileContents; set => _fileContents = value; }
        #endregion

        #region Helper methods
        /// <summary>
        /// Reads the file if the file does not exist, the function throws exception.
        /// </summary>
        /// <returns></returns>
        private void ReadLogFile()
        {
            this.FileContents = File.ReadAllText(this.Path);
        } 
        #endregion
    }
}
