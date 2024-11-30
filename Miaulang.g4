grammar Miaulang;


script: line* EOF;


line: command;

command
	: BONK IDENTIFIER L_PARENTHESIS args? R_PARENTHESIS	#bonkCommand
	| IDENTIFIER expression* DOT						#callCommand
	;

block: command* END ;

expression
	: invoke											# invokeExpression
	| NOT expression									# notExpression
	| L_PARENTHESIS expression R_PARENTHESIS			# parenthesisExpression
	| left=expression POWER_OP right=expression			# powerExpression
	| left=expression MULT_OP right=expression			# multExpression
	| left=expression ADD_OP right=expression			# addExpression
	| left=expression COMPARE_OP right=expression		# compareExpression
	| left=expression BOOL_OP right=expression			# boolExpression
	;


value
	: INTEGER
	| STRING
	;

invoke: IDENTIFIER L_PARENTHESIS invokeArgs R_PARENTHESIS ;

args: IDENTIFIER (COMMA IDENTIFIER)*			;
invokeArgs: expression (COMMA expression)*		;

STRING:			'"' ~('"')* '"'					;
INTEGER:		[0-9]+							;
IDENTIFIER:		[a-zA-Z_]+						;


L_PARENTHESIS:	'('				;
R_PARENTHESIS:	')'				;

POWER_OP:		'^'												;
MULT_OP:		'*' | '/' | '%'									;
ADD_OP:			'-' | '+'										;
COMPARE_OP:		'==' | '!=' | '>' | '>=' | '<' | '<='			;
BOOL_OP:		'or' | 'xor' | 'nor' | 'xnor' | 'and' | 'nand'	;
NOT:			'not'											;

BONK:			'bonk'			;
CAT:			'cat'			;
DOT:			'.'				;
COMMA:			','				;
EQUALSIGN:		'='				;
END:			'end'			;

FI:				'fi'			;

WS:		  [ \r\t\n]+ -> skip	;
ANY:			.				;