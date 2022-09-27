// See https://aka.ms/new-console-template for more information
using Markdown2HTMLLib;
using System.Text;

Console.WriteLine("Hello, World!");
ConvertEngine convertEngine = new ConvertEngine();
var output = convertEngine.Convert("## This is a header [with a link](http://yahoo.com)");
Console.WriteLine(output);
output = convertEngine.Convert("## This is a header [with a link1](http://yahoo.com) and this [with a link2](http://google.com)");
Console.WriteLine(output);
output = convertEngine.Convert("This is a paragraph [with an inline link](http://google.com). Neat, eh?");
Console.WriteLine(output);
// Console.ReadLine();

// File name  
string fileName = @".\Markdown1.txt";
StringBuilder sb = new StringBuilder();
try
{
    // Create a StreamReader  
    using (StreamReader reader = new StreamReader(fileName))
    {
        string line;
        
        // Read line by line  
        while ((line = reader.ReadLine()) != null)
        {
            var outputLine = convertEngine.Convert(line);
            sb.Append(outputLine);
            sb.Append(Environment.NewLine);
        }
    }
}
catch (Exception exp)
{
    Console.WriteLine(exp.Message);
}

string outputFileName = $".\\output_{DateTime.Now.Ticks}.html";
try
{
    using (StreamWriter writer = new StreamWriter(outputFileName))
    {
        writer.WriteLine(sb.ToString());
    }
}
catch (Exception exp)
{
    Console.Write(exp.Message);
}