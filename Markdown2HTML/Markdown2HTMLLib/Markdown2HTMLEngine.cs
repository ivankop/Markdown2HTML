using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markdown2HTMLLib
{
    public class ConvertEngine
    {
        List<IMarkdownConverter> converters = new List<IMarkdownConverter>();
        public ConvertEngine()
        {
            // build engine with list of converter in order of priorities
            converters.Add(new LinkConverter());
            converters.Add(new HeadingConverter());
            converters.Add(new BaseConverter());
        }

        public string Convert(string input)
        {
            foreach (var converter in converters)
            {
                if(converter.CanConvert(input))
                {
                    input = converter.Convert(input);
                    if (!converter.IsInlineConverter())
                    {
                        return input;
                    }
                }
            }
            return input;
        }
    }
}
