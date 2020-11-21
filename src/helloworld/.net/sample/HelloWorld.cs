using Antlr4.Runtime.Misc;

namespace sample
{
    class HelloWorld : HelloBaseVisitor<string>
    {
        public override string VisitR([NotNull] HelloParser.RContext context)
        {
            System.Console.WriteLine("In Visit");
            System.Console.WriteLine(context.ID().GetText());
            return context.ID().GetText();
        }
    }
}