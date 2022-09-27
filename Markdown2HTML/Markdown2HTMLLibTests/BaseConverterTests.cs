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
    public class BaseConverterTests
    {
        [TestMethod()]
        public void ConvertTest1()
        {
            BaseConverter converter = new BaseConverter();
            var output = converter.CanConvert("");
            Assert.IsFalse(output);
        }

        [TestMethod()]
        public void ConvertTest2()
        {
            BaseConverter converter = new BaseConverter();
            var output = converter.CanConvert(null);
            Assert.IsFalse(output);
        }

        [TestMethod()]
        public void ConvertTest3()
        {
            BaseConverter converter = new BaseConverter();
            var output = converter.Convert("   This is a paragraph  ");
            Assert.IsTrue(output == "<p>This is a paragraph</p>");
        }
    }
}