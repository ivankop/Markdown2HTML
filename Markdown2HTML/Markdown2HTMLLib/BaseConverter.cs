using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markdown2HTMLLib
{
    /// <summary>
    /// Base class for all markdown to HTML converter    
    /// </summary>
    public class BaseConverter : IMarkdownConverter
    {
        /// <summary>
        /// Ignore the empty or null input string
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>True or False</returns>
        public virtual bool CanConvert(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// It will wrap the input string with <p></p> element
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>Output HTML string</returns>
        public virtual string Convert(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            var ele = "p";
            return $"<{ele}>{input.Trim()}</{ele}>";
        }

        /// <summary>
        /// Engine will stop process another converters if this is not a inline converter 
        /// </summary>
        /// <returns>True or False</returns>
        public virtual bool IsInlineConverter()
        {
            return false;
        }
    }
}
