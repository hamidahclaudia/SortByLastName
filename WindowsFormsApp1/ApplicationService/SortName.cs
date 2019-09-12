using SortByLastNameApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.ApplicationShared.FileHelper;
using WindowsFormsApp1.ApplicationShared.SortName;
using WindowsFormsApp1.ApplicationShared.SortName.Model;

namespace WindowsFormsApp1.ApplicationService
{
    public class SortName : ISortName
    {

        private List<Name> GetListOfName(string text)
        {
            List<Name> names = new List<Name>();
            var textName = text.Split(new[] { "\r\n" }, StringSplitOptions.None).ToList();
            textName = textName.Where(x => x.Length > 0).Select(x => x).ToList();

            foreach (var name in textName)
            {
                Name newName = new Name();
                newName.fullName = name;
                newName.lastName = name.Split().LastOrDefault();
                newName.firstName = name.Split().FirstOrDefault();
                names.Add(newName);
            }

            return names;
        } 

        public List<string> SortByLastName(string text, string path)
        {
            var nameList = GetListOfName(text);
            nameList = nameList.OrderBy(x => x.lastName).ToList();
            var sortedNameList = nameList.Select(x => x.fullName).ToList();  
            
            return sortedNameList;
        }

        public List<string> SortByFirstName(string text, string path)
        {
            var nameList = GetListOfName(text);
            nameList = nameList.OrderBy(x => x.firstName).ToList();
            var sortedNameList = nameList.Select(x => x.fullName).ToList();

            return sortedNameList;
        }
    }
}
