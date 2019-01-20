using System;
using System.Collections.Generic;
using System.Linq;

namespace SortByLastNameApp
{
    public class SortName
    {
        private List<Name> names;

        public String ReadUnsortedList(String text)
        {
            String result = "";
            try
            {
                //Read file
                result = System.IO.File.ReadAllText(text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }

        public String SortByLastname(String text, String path)
        {
            String resultText = "";
            String fileNameSorted = "sorted-name-list.txt";
            String fileNameUnsorted = path.Split(new char[] { '\\' }).Last();
            String resultFullPathSorted = path.Replace(fileNameUnsorted, fileNameSorted);

            names = new List<Name>();

            //Split text per line
            String[] textName = text.Split(new[] { "\r\n" }, StringSplitOptions.None);

            try
            {
                foreach (var name in textName)
                {
                    Name newName = new Name();
                    newName.fullName = name;
                    newName.lastName = name.Split().LastOrDefault();
                    names.Add(newName);
                }

                //Sort By Lastname
                names = names.OrderBy(x => x.lastName).ToList();

                //Write to .txt file
                System.IO.File.WriteAllLines(resultFullPathSorted, names.Select(x => x.fullName));

                //Write for screen
                resultText = "You can access the sorted list on "
                    + resultFullPathSorted + "\r\n\r\n"
                    + System.IO.File.ReadAllText(resultFullPathSorted);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return resultText;
        }
    }
}
