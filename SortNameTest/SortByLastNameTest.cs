using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortByLastNameApp;

namespace SortNameTest
{
    [TestClass]
    public class SortByLastNameTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            SortName sort = new SortName();
            String pathFileUnsorted = "C:\\Users\\Claudia\\source\\repos\\SortByLastNameApp\\SortNameTest\\FileUnsorted\\unsorted-name.txt";
            String pathExpectedResult = "C:\\Users\\Claudia\\source\\repos\\SortByLastNameApp\\SortNameTest\\FileUnsorted\\testExpected.txt";

            String text = System.IO.File.ReadAllText(pathFileUnsorted);

            String expectedResult = System.IO.File.ReadAllText(pathExpectedResult);

            String sorted = sort.SortByLastname(text, pathFileUnsorted);

            Assert.AreEqual(expectedResult, sorted, "The result is not same as expected");



        }
    }
}
