using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.ApplicationShared.FileHelper;

namespace WindowsFormsApp1
{
    public class FileHelper : IFileHelper

    {
        private string filePath;

        public FileHelper(string filePath)
        {
            this.filePath = filePath;
        }


        public string ReadTextFile(string path)
        {
            String result = "";
            try
            {
                //Read file
                result = System.IO.File.ReadAllText(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }


        public void WriteFile(string path, List<string> text)
        {
            try
            {
                System.IO.File.WriteAllLines(path, text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
