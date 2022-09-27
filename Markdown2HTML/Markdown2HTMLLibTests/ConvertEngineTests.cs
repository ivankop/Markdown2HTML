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
    public class ConvertEngineTests
    {
        [TestMethod()]
        public void ConvertTest()
        {
            ConvertEngine engine = new ConvertEngine();
            var output = engine.Convert("");
            Assert.IsTrue(output == "");
        }

        [TestMethod()]
        public void ConvertTest1()
        {
            ConvertEngine engine = new ConvertEngine();
            var output = engine.Convert("This is a *paragraph* [with an *inline* link](http://google.com). Neat, eh?");
            Assert.IsTrue(output == "<p>This is a <i>paragraph</i> <a href=\"http://google.com\">with an <i>inline</i> link</a>. Neat, eh?</p>");
        }

        [TestMethod()]
        public void ConvertTest2()
        {
            ConvertEngine engine = new ConvertEngine();
            var output = engine.Convert("###This is a *paragraph* [with an *inline* link](http://google.com). Neat, eh?");
            Assert.IsTrue(output == "<h3>This is a <i>paragraph</i> <a href=\"http://google.com\">with an <i>inline</i> link</a>. Neat, eh?</h3>");
        }


        [TestMethod()]
        public void ConvertTest3()
        {
            ConvertEngine engine = new ConvertEngine();
            var output = engine.Convert("###This is a *line* [with an *inline* link](http://google.com). And this link [with a link](http://yahoo.com)");
            Assert.IsTrue(output == "<h3>This is a <i>line</i> <a href=\"http://google.com\">with an <i>inline</i> link</a>. And this link <a href=\"http://yahoo.com\">with a link</a></h3>");
        }
    }
}