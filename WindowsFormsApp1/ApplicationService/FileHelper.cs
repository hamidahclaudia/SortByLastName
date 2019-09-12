using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.ApplicationShared.FileHelper;

namespace WindowsFormsApp1.ApplicationService
{
    public class FileHelper : IFileHelper
    {
        public string ReadTextFile(string path)
        {
            String result = "";
            try
            { 
                result = System.IO.File.ReadAllText(path);
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
