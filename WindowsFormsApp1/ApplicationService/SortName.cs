using SortByLastNameApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.ApplicationEntity;
using WindowsFormsApp1.ApplicationShared.FileHelper;
using WindowsFormsApp1.ApplicationShared.SortName;

namespace WindowsFormsApp1.ApplicationService
{
    public class SortName : ISortName
    {
        private List<Name> names;
        private IFileHelper fileHelper;

        public SortName(List<Name> names, IFileHelper fileHelper)
        {
            this.names = names;
            this.fileHelper = fileHelper;
        }

        private List<Name> GetListOfName(string text)
        {
            String[] textName = text.Split(new[] { "\r\n" }, StringSplitOptions.None);
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
            names = names.OrderBy(x => x.lastName).ToList();

            var sortedNameList = names.Select(x => x.fullName).ToList();
           
            return sortedNameList;
        }


        public List<string> SortByFirstName(string text, string path)
        {
            var nameList = GetListOfName(text);
            names = names.OrderBy(x => x.firstName).ToList();

            var sortedNameList = names.Select(x => x.fullName).ToList();

            return sortedNameList;
        }
    }
}
