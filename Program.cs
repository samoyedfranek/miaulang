using Antlr4.Runtime;
using miaulang;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Script\script.txt";

        string text = File.ReadAllText(path);

        AntlrInputStream inputStream = new(text);
        MiaulangLexer lexer = new(inputStream);
        CommonTokenStream commonTokenStream = new(lexer);
        MiaulangParser parser = new(commonTokenStream);
        MiaulangParser.ScriptContext chatContext = parser.script();
        MiaulangVisitor visitor = new();
        visitor.Visit(chatContext);

    }
}
