using System;
using System.IO;

namespace MC.FileAccess
{
    public class FileLoader
    {
        public File LoadFile(string path)
        {
            if (IsPathFile(path) && IsFileExist(path))
            {

            }

            throw new ArgumentException("The provided file does not exist or the path given is not a file.");
        } 

        private bool IsFileExist(string path)
        {
            return false;
        }

        private bool IsPathFile(string path)
        {
            return false;
        }


    }
}
