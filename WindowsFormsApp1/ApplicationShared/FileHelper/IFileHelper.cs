using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ApplicationShared.FileHelper
{
    public interface IFileHelper
    {
        string ReadTextFile(string path);

        void WriteFile(string path, List<string> text);


    }
}
