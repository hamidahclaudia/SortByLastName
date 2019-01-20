using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SortedName
{
    public class SortName
    {
        private List<Name> names;

        public String ReadUnsortedName(String text)
        {
            String result = "";
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(text))
                {
                    result = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }

        public String SortByLastname(String text)
        {
            String result = "";
            names = new List<Name>();
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
                names = names.OrderBy(x => x.lastName).ToList();
                foreach (var name in names)
                {
                    result += name.fullName + "\r\n";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }
    }
}
