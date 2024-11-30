﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\src\miaulang\miaulang\Miaulang.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace miaulang {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="MiaulangParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IMiaulangVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>bonkCommand</c>
	/// labeled alternative in <see cref="MiaulangParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBonkCommand([NotNull] MiaulangParser.BonkCommandContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>callCommand</c>
	/// labeled alternative in <see cref="MiaulangParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCallCommand([NotNull] MiaulangParser.CallCommandContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>invokeExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInvokeExpression([NotNull] MiaulangParser.InvokeExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNotExpression([NotNull] MiaulangParser.NotExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>parenthesisExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesisExpression([NotNull] MiaulangParser.ParenthesisExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>powerExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPowerExpression([NotNull] MiaulangParser.PowerExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>multExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultExpression([NotNull] MiaulangParser.MultExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>addExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddExpression([NotNull] MiaulangParser.AddExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>compareExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompareExpression([NotNull] MiaulangParser.CompareExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>boolExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolExpression([NotNull] MiaulangParser.BoolExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MiaulangParser.script"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScript([NotNull] MiaulangParser.ScriptContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MiaulangParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLine([NotNull] MiaulangParser.LineContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MiaulangParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCommand([NotNull] MiaulangParser.CommandContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MiaulangParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] MiaulangParser.BlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] MiaulangParser.ExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MiaulangParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValue([NotNull] MiaulangParser.ValueContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MiaulangParser.invoke"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInvoke([NotNull] MiaulangParser.InvokeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MiaulangParser.args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgs([NotNull] MiaulangParser.ArgsContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MiaulangParser.invokeArgs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInvokeArgs([NotNull] MiaulangParser.InvokeArgsContext context);
}
} // namespace miaulang