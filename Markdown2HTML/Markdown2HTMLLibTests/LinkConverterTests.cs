using Microsoft.VisualStudio.TestTools.UnitTesting;
using Markdown2HTMLLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markdown2HTMLLib.Tests
{
    [TestClass()]
    public class LinkConverterTests
    {
        [TestMethod()]
        public void ConvertTest1()
        {
            LinkConverter converter = new LinkConverter();
            var output  = converter.Convert("");
            Assert.IsTrue(string.IsNullOrEmpty(output));
        }

        [TestMethod()]
        public void ConvertTest2()
        {
            LinkConverter converter = new LinkConverter();
            string input = "Text string with no link";
            var output = converter.Convert(input);
            Assert.IsTrue(output == input);
        }

        [TestMethod()]
        public void ConvertTest3()
        {
            LinkConverter converter = new LinkConverter();
            string input = "This is a paragraph [with an inline link](http://google.com). Neat, eh?";
            var output = converter.Convert(input);
            Assert.IsTrue(output == "This is a paragraph <a href=\"http://google.com\">with an inline link</a>. Neat, eh?");
        }

        [TestMethod()]
        public void ConvertTest4()
        {
            LinkConverter converter = new LinkConverter();
            var output = converter.CanConvert("abc");
            Assert.IsFalse(output);
        }
    }
}