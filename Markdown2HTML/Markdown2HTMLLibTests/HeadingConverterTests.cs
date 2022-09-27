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
    public class HeadingConverterTests
    {
        [TestMethod()]
        public void ConvertTest1()
        {
            HeadingConverter converter = new HeadingConverter();
            var output = converter.Convert("");
            Assert.IsTrue(string.IsNullOrEmpty(output));
        }

        [TestMethod()]
        public void ConvertTest2()
        {
            HeadingConverter converter = new HeadingConverter();
            var output = converter.Convert("# Heading 1");
            Assert.IsTrue(output == "<h1>Heading 1</h1>");
        }

        [TestMethod()]
        public void ConvertTest3()
        {
            HeadingConverter converter = new HeadingConverter();
            var output = converter.Convert("## Heading 2");
            Assert.IsTrue(output == "<h2>Heading 2</h2>");
        }

        [TestMethod()]
        public void ConvertTest4()
        {
            HeadingConverter converter = new HeadingConverter();
            var output = converter.Convert("###### Heading 6");
            Assert.IsTrue(output == "<h6>Heading 6</h6>");
        }
    }
}