using System;
using Antlr4.Runtime;

namespace sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = "hello jamalapuram";
            var input = new AntlrInputStream(value);
            var lexer = new HelloLexer(input);
            var tokens = new CommonTokenStream(lexer);
            var parser = new HelloParser(tokens);
            if(parser.BuildParseTree){
                System.Console.WriteLine("parse tree build");
                var hw = new HelloWorld();
                var output = hw.Visit(parser.r());
                System.Console.WriteLine($">> output:{output} ");
            }else{
                System.Console.WriteLine("parse tree not build.");
            }
           // Console.WriteLine("Hello World!");
        }
    }
}
