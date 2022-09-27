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
    public class ItalicConverterTests
    {
        [TestMethod()]
        public void ConvertTest()
        {
            ItalicConverter converter = new ItalicConverter();
            var output = converter.CanConvert("some text");
            Assert.IsFalse(output);
        }

        [TestMethod()]
        public void ConvertTest2()
        {
            ItalicConverter converter = new ItalicConverter();
            string input = "Text *italic* string";
            var output = converter.Convert(input);
            Assert.IsTrue(output == "Text <i>italic</i> string");
        }
    }
}