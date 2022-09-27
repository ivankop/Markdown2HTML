using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markdown2HTMLLib
{
    public class HeadingConverter : BaseConverter
    {
        /// <summary>
        /// Return False if the input string is not start with #
        /// </summary>        
        public override bool CanConvert(string input)
        {
            if (input.StartsWith("#"))
            {
                return true;
            }
            return false;
        }

        /// <inheritdoc />
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
