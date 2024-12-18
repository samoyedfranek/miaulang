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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class MiaulangParser : Parser {
	public const int
		STRING=1, INTEGER=2, IDENTIFIER=3, L_PARENTHESIS=4, R_PARENTHESIS=5, POWER_OP=6, 
		MULT_OP=7, ADD_OP=8, COMPARE_OP=9, BOOL_OP=10, NOT=11, BONK=12, CAT=13, 
		DOT=14, COMMA=15, EQUALSIGN=16, END=17, FI=18, WS=19, ANY=20;
	public const int
		RULE_script = 0, RULE_line = 1, RULE_command = 2, RULE_block = 3, RULE_expression = 4, 
		RULE_value = 5, RULE_invoke = 6, RULE_args = 7, RULE_invokeArgs = 8;
	public static readonly string[] ruleNames = {
		"script", "line", "command", "block", "expression", "value", "invoke", 
		"args", "invokeArgs"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, null, "'('", "')'", "'^'", null, null, null, null, "'not'", 
		"'bonk'", "'cat'", "'.'", "','", "'='", "'end'", "'fi'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "STRING", "INTEGER", "IDENTIFIER", "L_PARENTHESIS", "R_PARENTHESIS", 
		"POWER_OP", "MULT_OP", "ADD_OP", "COMPARE_OP", "BOOL_OP", "NOT", "BONK", 
		"CAT", "DOT", "COMMA", "EQUALSIGN", "END", "FI", "WS", "ANY"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Miaulang.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public MiaulangParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class ScriptContext : ParserRuleContext {
		public ITerminalNode Eof() { return GetToken(MiaulangParser.Eof, 0); }
		public LineContext[] line() {
			return GetRuleContexts<LineContext>();
		}
		public LineContext line(int i) {
			return GetRuleContext<LineContext>(i);
		}
		public ScriptContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_script; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.EnterScript(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.ExitScript(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMiaulangVisitor<TResult> typedVisitor = visitor as IMiaulangVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitScript(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ScriptContext script() {
		ScriptContext _localctx = new ScriptContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_script);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 21;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==IDENTIFIER || _la==BONK) {
				{
				{
				State = 18; line();
				}
				}
				State = 23;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 24; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LineContext : ParserRuleContext {
		public CommandContext command() {
			return GetRuleContext<CommandContext>(0);
		}
		public LineContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_line; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.EnterLine(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.ExitLine(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMiaulangVisitor<TResult> typedVisitor = visitor as IMiaulangVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLine(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LineContext line() {
		LineContext _localctx = new LineContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_line);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 26; command();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CommandContext : ParserRuleContext {
		public CommandContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_command; } }
	 
		public CommandContext() { }
		public virtual void CopyFrom(CommandContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class BonkCommandContext : CommandContext {
		public ITerminalNode BONK() { return GetToken(MiaulangParser.BONK, 0); }
		public ITerminalNode IDENTIFIER() { return GetToken(MiaulangParser.IDENTIFIER, 0); }
		public ITerminalNode L_PARENTHESIS() { return GetToken(MiaulangParser.L_PARENTHESIS, 0); }
		public ITerminalNode R_PARENTHESIS() { return GetToken(MiaulangParser.R_PARENTHESIS, 0); }
		public ArgsContext args() {
			return GetRuleContext<ArgsContext>(0);
		}
		public BonkCommandContext(CommandContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.EnterBonkCommand(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.ExitBonkCommand(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMiaulangVisitor<TResult> typedVisitor = visitor as IMiaulangVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBonkCommand(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class CallCommandContext : CommandContext {
		public ITerminalNode IDENTIFIER() { return GetToken(MiaulangParser.IDENTIFIER, 0); }
		public ITerminalNode DOT() { return GetToken(MiaulangParser.DOT, 0); }
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public CallCommandContext(CommandContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.EnterCallCommand(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.ExitCallCommand(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMiaulangVisitor<TResult> typedVisitor = visitor as IMiaulangVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCallCommand(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CommandContext command() {
		CommandContext _localctx = new CommandContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_command);
		int _la;
		try {
			State = 43;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case BONK:
				_localctx = new BonkCommandContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 28; Match(BONK);
				State = 29; Match(IDENTIFIER);
				State = 30; Match(L_PARENTHESIS);
				State = 32;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==IDENTIFIER) {
					{
					State = 31; args();
					}
				}

				State = 34; Match(R_PARENTHESIS);
				}
				break;
			case IDENTIFIER:
				_localctx = new CallCommandContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 35; Match(IDENTIFIER);
				State = 39;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << IDENTIFIER) | (1L << L_PARENTHESIS) | (1L << NOT))) != 0)) {
					{
					{
					State = 36; expression(0);
					}
					}
					State = 41;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				State = 42; Match(DOT);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BlockContext : ParserRuleContext {
		public ITerminalNode END() { return GetToken(MiaulangParser.END, 0); }
		public CommandContext[] command() {
			return GetRuleContexts<CommandContext>();
		}
		public CommandContext command(int i) {
			return GetRuleContext<CommandContext>(i);
		}
		public BlockContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_block; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.EnterBlock(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.ExitBlock(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMiaulangVisitor<TResult> typedVisitor = visitor as IMiaulangVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBlock(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public BlockContext block() {
		BlockContext _localctx = new BlockContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_block);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 48;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==IDENTIFIER || _la==BONK) {
				{
				{
				State = 45; command();
				}
				}
				State = 50;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 51; Match(END);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
	 
		public ExpressionContext() { }
		public virtual void CopyFrom(ExpressionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class InvokeExpressionContext : ExpressionContext {
		public InvokeContext invoke() {
			return GetRuleContext<InvokeContext>(0);
		}
		public InvokeExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.EnterInvokeExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.ExitInvokeExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMiaulangVisitor<TResult> typedVisitor = visitor as IMiaulangVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInvokeExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NotExpressionContext : ExpressionContext {
		public ITerminalNode NOT() { return GetToken(MiaulangParser.NOT, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public NotExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.EnterNotExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.ExitNotExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMiaulangVisitor<TResult> typedVisitor = visitor as IMiaulangVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNotExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ParenthesisExpressionContext : ExpressionContext {
		public ITerminalNode L_PARENTHESIS() { return GetToken(MiaulangParser.L_PARENTHESIS, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode R_PARENTHESIS() { return GetToken(MiaulangParser.R_PARENTHESIS, 0); }
		public ParenthesisExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.EnterParenthesisExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.ExitParenthesisExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMiaulangVisitor<TResult> typedVisitor = visitor as IMiaulangVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParenthesisExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class PowerExpressionContext : ExpressionContext {
		public ExpressionContext left;
		public ExpressionContext right;
		public ITerminalNode POWER_OP() { return GetToken(MiaulangParser.POWER_OP, 0); }
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public PowerExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.EnterPowerExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.ExitPowerExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMiaulangVisitor<TResult> typedVisitor = visitor as IMiaulangVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPowerExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class MultExpressionContext : ExpressionContext {
		public ExpressionContext left;
		public ExpressionContext right;
		public ITerminalNode MULT_OP() { return GetToken(MiaulangParser.MULT_OP, 0); }
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public MultExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.EnterMultExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.ExitMultExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMiaulangVisitor<TResult> typedVisitor = visitor as IMiaulangVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMultExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AddExpressionContext : ExpressionContext {
		public ExpressionContext left;
		public ExpressionContext right;
		public ITerminalNode ADD_OP() { return GetToken(MiaulangParser.ADD_OP, 0); }
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public AddExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.EnterAddExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.ExitAddExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMiaulangVisitor<TResult> typedVisitor = visitor as IMiaulangVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAddExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class CompareExpressionContext : ExpressionContext {
		public ExpressionContext left;
		public ExpressionContext right;
		public ITerminalNode COMPARE_OP() { return GetToken(MiaulangParser.COMPARE_OP, 0); }
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public CompareExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.EnterCompareExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.ExitCompareExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMiaulangVisitor<TResult> typedVisitor = visitor as IMiaulangVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCompareExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class BoolExpressionContext : ExpressionContext {
		public ExpressionContext left;
		public ExpressionContext right;
		public ITerminalNode BOOL_OP() { return GetToken(MiaulangParser.BOOL_OP, 0); }
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public BoolExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.EnterBoolExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.ExitBoolExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMiaulangVisitor<TResult> typedVisitor = visitor as IMiaulangVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBoolExpression(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		return expression(0);
	}

	private ExpressionContext expression(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		ExpressionContext _localctx = new ExpressionContext(_ctx, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 8;
		EnterRecursionRule(_localctx, 8, RULE_expression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 61;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case IDENTIFIER:
				{
				_localctx = new InvokeExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				State = 54; invoke();
				}
				break;
			case NOT:
				{
				_localctx = new NotExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 55; Match(NOT);
				State = 56; expression(7);
				}
				break;
			case L_PARENTHESIS:
				{
				_localctx = new ParenthesisExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 57; Match(L_PARENTHESIS);
				State = 58; expression(0);
				State = 59; Match(R_PARENTHESIS);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			_ctx.stop = _input.Lt(-1);
			State = 80;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,7,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 78;
					_errHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(_input,6,_ctx) ) {
					case 1:
						{
						_localctx = new PowerExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((PowerExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 63;
						if (!(Precpred(_ctx, 5))) throw new FailedPredicateException(this, "Precpred(_ctx, 5)");
						State = 64; Match(POWER_OP);
						State = 65; ((PowerExpressionContext)_localctx).right = expression(6);
						}
						break;

					case 2:
						{
						_localctx = new MultExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((MultExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 66;
						if (!(Precpred(_ctx, 4))) throw new FailedPredicateException(this, "Precpred(_ctx, 4)");
						State = 67; Match(MULT_OP);
						State = 68; ((MultExpressionContext)_localctx).right = expression(5);
						}
						break;

					case 3:
						{
						_localctx = new AddExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((AddExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 69;
						if (!(Precpred(_ctx, 3))) throw new FailedPredicateException(this, "Precpred(_ctx, 3)");
						State = 70; Match(ADD_OP);
						State = 71; ((AddExpressionContext)_localctx).right = expression(4);
						}
						break;

					case 4:
						{
						_localctx = new CompareExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((CompareExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 72;
						if (!(Precpred(_ctx, 2))) throw new FailedPredicateException(this, "Precpred(_ctx, 2)");
						State = 73; Match(COMPARE_OP);
						State = 74; ((CompareExpressionContext)_localctx).right = expression(3);
						}
						break;

					case 5:
						{
						_localctx = new BoolExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((BoolExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 75;
						if (!(Precpred(_ctx, 1))) throw new FailedPredicateException(this, "Precpred(_ctx, 1)");
						State = 76; Match(BOOL_OP);
						State = 77; ((BoolExpressionContext)_localctx).right = expression(2);
						}
						break;
					}
					} 
				}
				State = 82;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,7,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class ValueContext : ParserRuleContext {
		public ITerminalNode INTEGER() { return GetToken(MiaulangParser.INTEGER, 0); }
		public ITerminalNode STRING() { return GetToken(MiaulangParser.STRING, 0); }
		public ValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_value; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.EnterValue(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.ExitValue(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMiaulangVisitor<TResult> typedVisitor = visitor as IMiaulangVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitValue(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ValueContext value() {
		ValueContext _localctx = new ValueContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_value);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 83;
			_la = _input.La(1);
			if ( !(_la==STRING || _la==INTEGER) ) {
			_errHandler.RecoverInline(this);
			} else {
				if (_input.La(1) == TokenConstants.Eof) {
					matchedEOF = true;
				}

				_errHandler.ReportMatch(this);
				Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InvokeContext : ParserRuleContext {
		public ITerminalNode IDENTIFIER() { return GetToken(MiaulangParser.IDENTIFIER, 0); }
		public ITerminalNode L_PARENTHESIS() { return GetToken(MiaulangParser.L_PARENTHESIS, 0); }
		public InvokeArgsContext invokeArgs() {
			return GetRuleContext<InvokeArgsContext>(0);
		}
		public ITerminalNode R_PARENTHESIS() { return GetToken(MiaulangParser.R_PARENTHESIS, 0); }
		public InvokeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_invoke; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.EnterInvoke(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.ExitInvoke(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMiaulangVisitor<TResult> typedVisitor = visitor as IMiaulangVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInvoke(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public InvokeContext invoke() {
		InvokeContext _localctx = new InvokeContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_invoke);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 85; Match(IDENTIFIER);
			State = 86; Match(L_PARENTHESIS);
			State = 87; invokeArgs();
			State = 88; Match(R_PARENTHESIS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ArgsContext : ParserRuleContext {
		public ITerminalNode[] IDENTIFIER() { return GetTokens(MiaulangParser.IDENTIFIER); }
		public ITerminalNode IDENTIFIER(int i) {
			return GetToken(MiaulangParser.IDENTIFIER, i);
		}
		public ITerminalNode[] COMMA() { return GetTokens(MiaulangParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(MiaulangParser.COMMA, i);
		}
		public ArgsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_args; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.EnterArgs(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.ExitArgs(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMiaulangVisitor<TResult> typedVisitor = visitor as IMiaulangVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitArgs(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ArgsContext args() {
		ArgsContext _localctx = new ArgsContext(_ctx, State);
		EnterRule(_localctx, 14, RULE_args);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 90; Match(IDENTIFIER);
			State = 95;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==COMMA) {
				{
				{
				State = 91; Match(COMMA);
				State = 92; Match(IDENTIFIER);
				}
				}
				State = 97;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InvokeArgsContext : ParserRuleContext {
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode[] COMMA() { return GetTokens(MiaulangParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(MiaulangParser.COMMA, i);
		}
		public InvokeArgsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_invokeArgs; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.EnterInvokeArgs(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMiaulangListener typedListener = listener as IMiaulangListener;
			if (typedListener != null) typedListener.ExitInvokeArgs(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMiaulangVisitor<TResult> typedVisitor = visitor as IMiaulangVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInvokeArgs(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public InvokeArgsContext invokeArgs() {
		InvokeArgsContext _localctx = new InvokeArgsContext(_ctx, State);
		EnterRule(_localctx, 16, RULE_invokeArgs);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 98; expression(0);
			State = 103;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==COMMA) {
				{
				{
				State = 99; Match(COMMA);
				State = 100; expression(0);
				}
				}
				State = 105;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 4: return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(_ctx, 5);

		case 1: return Precpred(_ctx, 4);

		case 2: return Precpred(_ctx, 3);

		case 3: return Precpred(_ctx, 2);

		case 4: return Precpred(_ctx, 1);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x16m\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t"+
		"\t\x4\n\t\n\x3\x2\a\x2\x16\n\x2\f\x2\xE\x2\x19\v\x2\x3\x2\x3\x2\x3\x3"+
		"\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x5\x4#\n\x4\x3\x4\x3\x4\x3\x4\a\x4(\n\x4"+
		"\f\x4\xE\x4+\v\x4\x3\x4\x5\x4.\n\x4\x3\x5\a\x5\x31\n\x5\f\x5\xE\x5\x34"+
		"\v\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x5\x6"+
		"@\n\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3"+
		"\x6\x3\x6\x3\x6\x3\x6\x3\x6\a\x6Q\n\x6\f\x6\xE\x6T\v\x6\x3\a\x3\a\x3\b"+
		"\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3\t\a\t`\n\t\f\t\xE\t\x63\v\t\x3\n\x3"+
		"\n\x3\n\a\nh\n\n\f\n\xE\nk\v\n\x3\n\x2\x2\x3\n\v\x2\x2\x4\x2\x6\x2\b\x2"+
		"\n\x2\f\x2\xE\x2\x10\x2\x12\x2\x2\x3\x3\x2\x3\x4q\x2\x17\x3\x2\x2\x2\x4"+
		"\x1C\x3\x2\x2\x2\x6-\x3\x2\x2\x2\b\x32\x3\x2\x2\x2\n?\x3\x2\x2\x2\fU\x3"+
		"\x2\x2\x2\xEW\x3\x2\x2\x2\x10\\\x3\x2\x2\x2\x12\x64\x3\x2\x2\x2\x14\x16"+
		"\x5\x4\x3\x2\x15\x14\x3\x2\x2\x2\x16\x19\x3\x2\x2\x2\x17\x15\x3\x2\x2"+
		"\x2\x17\x18\x3\x2\x2\x2\x18\x1A\x3\x2\x2\x2\x19\x17\x3\x2\x2\x2\x1A\x1B"+
		"\a\x2\x2\x3\x1B\x3\x3\x2\x2\x2\x1C\x1D\x5\x6\x4\x2\x1D\x5\x3\x2\x2\x2"+
		"\x1E\x1F\a\xE\x2\x2\x1F \a\x5\x2\x2 \"\a\x6\x2\x2!#\x5\x10\t\x2\"!\x3"+
		"\x2\x2\x2\"#\x3\x2\x2\x2#$\x3\x2\x2\x2$.\a\a\x2\x2%)\a\x5\x2\x2&(\x5\n"+
		"\x6\x2\'&\x3\x2\x2\x2(+\x3\x2\x2\x2)\'\x3\x2\x2\x2)*\x3\x2\x2\x2*,\x3"+
		"\x2\x2\x2+)\x3\x2\x2\x2,.\a\x10\x2\x2-\x1E\x3\x2\x2\x2-%\x3\x2\x2\x2."+
		"\a\x3\x2\x2\x2/\x31\x5\x6\x4\x2\x30/\x3\x2\x2\x2\x31\x34\x3\x2\x2\x2\x32"+
		"\x30\x3\x2\x2\x2\x32\x33\x3\x2\x2\x2\x33\x35\x3\x2\x2\x2\x34\x32\x3\x2"+
		"\x2\x2\x35\x36\a\x13\x2\x2\x36\t\x3\x2\x2\x2\x37\x38\b\x6\x1\x2\x38@\x5"+
		"\xE\b\x2\x39:\a\r\x2\x2:@\x5\n\x6\t;<\a\x6\x2\x2<=\x5\n\x6\x2=>\a\a\x2"+
		"\x2>@\x3\x2\x2\x2?\x37\x3\x2\x2\x2?\x39\x3\x2\x2\x2?;\x3\x2\x2\x2@R\x3"+
		"\x2\x2\x2\x41\x42\f\a\x2\x2\x42\x43\a\b\x2\x2\x43Q\x5\n\x6\b\x44\x45\f"+
		"\x6\x2\x2\x45\x46\a\t\x2\x2\x46Q\x5\n\x6\aGH\f\x5\x2\x2HI\a\n\x2\x2IQ"+
		"\x5\n\x6\x6JK\f\x4\x2\x2KL\a\v\x2\x2LQ\x5\n\x6\x5MN\f\x3\x2\x2NO\a\f\x2"+
		"\x2OQ\x5\n\x6\x4P\x41\x3\x2\x2\x2P\x44\x3\x2\x2\x2PG\x3\x2\x2\x2PJ\x3"+
		"\x2\x2\x2PM\x3\x2\x2\x2QT\x3\x2\x2\x2RP\x3\x2\x2\x2RS\x3\x2\x2\x2S\v\x3"+
		"\x2\x2\x2TR\x3\x2\x2\x2UV\t\x2\x2\x2V\r\x3\x2\x2\x2WX\a\x5\x2\x2XY\a\x6"+
		"\x2\x2YZ\x5\x12\n\x2Z[\a\a\x2\x2[\xF\x3\x2\x2\x2\\\x61\a\x5\x2\x2]^\a"+
		"\x11\x2\x2^`\a\x5\x2\x2_]\x3\x2\x2\x2`\x63\x3\x2\x2\x2\x61_\x3\x2\x2\x2"+
		"\x61\x62\x3\x2\x2\x2\x62\x11\x3\x2\x2\x2\x63\x61\x3\x2\x2\x2\x64i\x5\n"+
		"\x6\x2\x65\x66\a\x11\x2\x2\x66h\x5\n\x6\x2g\x65\x3\x2\x2\x2hk\x3\x2\x2"+
		"\x2ig\x3\x2\x2\x2ij\x3\x2\x2\x2j\x13\x3\x2\x2\x2ki\x3\x2\x2\x2\f\x17\""+
		")-\x32?PR\x61i";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace miaulang
