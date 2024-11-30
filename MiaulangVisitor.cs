using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace miaulang
{
    internal class MiaulangVisitor : MiaulangBaseVisitor<object?>
    {
        public override object? VisitValue([NotNull] MiaulangParser.ValueContext context)
        {
            if (context.INTEGER() is { } num)
            {
                if (int.TryParse(num.GetText(), out int r))
                {
                    return r;
                }
                else throw new Exception($"Could not parse {num.GetText()} to a number");
            }
            else if (context.STRING() is { } str)
            {
                string s = str.GetText();

                if (s.Length < 2)
                    throw new Exception("String has a wrong format");

                return s[1..^1];
            }
            else throw new Exception("??????");
        }

        public override object VisitAddExpression([NotNull] MiaulangParser.AddExpressionContext context)
        {
            object? l = Visit(context.left);
            object? r = Visit(context.right);


        }

        public override object VisitBoolExpression([NotNull] MiaulangParser.BoolExpressionContext context)
        {
            return base.VisitBoolExpression(context);
        }
    }
}
