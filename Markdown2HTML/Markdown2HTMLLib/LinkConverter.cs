using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Markdown2HTMLLib
{
    public class LinkConverter : BaseConverter
    {
        private string _pattern = @"\[(?<text>[^\]]+)\]\((?<url>[^\)]+)\)";

        /// <inheritdoc />
        public override bool IsInlineConverter()
        {
            return true;
        }

        /// <inheritdoc />
        public override bool CanConvert(string input)
        {
            Regex regex = new Regex(_pattern);
            return regex.IsMatch(input);
        }

        /// <inheritdoc />
        public override string Convert(string input)
        {
            Regex regex = new Regex(_pattern);
            string output = regex.Replace(input, "<a href=\"${url}\">${text}</a>");

            return output;

        }
    }
}
