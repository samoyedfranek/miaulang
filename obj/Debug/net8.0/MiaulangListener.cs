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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="MiaulangParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IMiaulangListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>bonkCommand</c>
	/// labeled alternative in <see cref="MiaulangParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBonkCommand([NotNull] MiaulangParser.BonkCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>bonkCommand</c>
	/// labeled alternative in <see cref="MiaulangParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBonkCommand([NotNull] MiaulangParser.BonkCommandContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>callCommand</c>
	/// labeled alternative in <see cref="MiaulangParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCallCommand([NotNull] MiaulangParser.CallCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>callCommand</c>
	/// labeled alternative in <see cref="MiaulangParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCallCommand([NotNull] MiaulangParser.CallCommandContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>invokeExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInvokeExpression([NotNull] MiaulangParser.InvokeExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>invokeExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInvokeExpression([NotNull] MiaulangParser.InvokeExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotExpression([NotNull] MiaulangParser.NotExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotExpression([NotNull] MiaulangParser.NotExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesisExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesisExpression([NotNull] MiaulangParser.ParenthesisExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesisExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesisExpression([NotNull] MiaulangParser.ParenthesisExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>powerExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPowerExpression([NotNull] MiaulangParser.PowerExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>powerExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPowerExpression([NotNull] MiaulangParser.PowerExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>multExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultExpression([NotNull] MiaulangParser.MultExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultExpression([NotNull] MiaulangParser.MultExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>addExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddExpression([NotNull] MiaulangParser.AddExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>addExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddExpression([NotNull] MiaulangParser.AddExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>compareExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompareExpression([NotNull] MiaulangParser.CompareExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>compareExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompareExpression([NotNull] MiaulangParser.CompareExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>boolExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolExpression([NotNull] MiaulangParser.BoolExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>boolExpression</c>
	/// labeled alternative in <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolExpression([NotNull] MiaulangParser.BoolExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiaulangParser.script"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScript([NotNull] MiaulangParser.ScriptContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiaulangParser.script"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScript([NotNull] MiaulangParser.ScriptContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiaulangParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLine([NotNull] MiaulangParser.LineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiaulangParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLine([NotNull] MiaulangParser.LineContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiaulangParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommand([NotNull] MiaulangParser.CommandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiaulangParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommand([NotNull] MiaulangParser.CommandContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiaulangParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] MiaulangParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiaulangParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] MiaulangParser.BlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] MiaulangParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiaulangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] MiaulangParser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiaulangParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValue([NotNull] MiaulangParser.ValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiaulangParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValue([NotNull] MiaulangParser.ValueContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiaulangParser.invoke"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInvoke([NotNull] MiaulangParser.InvokeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiaulangParser.invoke"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInvoke([NotNull] MiaulangParser.InvokeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiaulangParser.args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgs([NotNull] MiaulangParser.ArgsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiaulangParser.args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgs([NotNull] MiaulangParser.ArgsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiaulangParser.invokeArgs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInvokeArgs([NotNull] MiaulangParser.InvokeArgsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiaulangParser.invokeArgs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInvokeArgs([NotNull] MiaulangParser.InvokeArgsContext context);
}
} // namespace miaulang
