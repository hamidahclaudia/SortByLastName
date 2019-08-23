using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ApplicationShared.SortName
{
    public interface ISortName
    {
        List<string> SortByLastName(string text, String path);

        List<string> SortByFirstName(string text, String path);
    }
}
