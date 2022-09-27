using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markdown2HTMLLib
{
    public class HeadingConverter : BaseConverter
    {
        public override bool CanConvert(string input)
        {
            if (input.StartsWith("#"))
            {
                return true;
            }
            return false;
        }

        public override string Convert(string input)
        {
            if (!CanConvert(input))
            {
                return input;
            }
            input = input.Trim();
            int count = 0;
            while (input[count] == '#')
            {
                count++;
            }
            var ele = "h" + count;
            return $"<{ele}>{input.Substring(count, input.Length - count).Trim()}</{ele}>";
        }
    }
}
