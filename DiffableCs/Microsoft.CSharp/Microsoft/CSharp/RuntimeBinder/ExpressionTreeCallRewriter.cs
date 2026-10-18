namespace Microsoft.CSharp.RuntimeBinder;

internal sealed class ExpressionTreeCallRewriter : ExprVisitorBase
{
	private sealed class ExpressionExpr : Expr
	{
		public readonly Expression Expression; //Field offset: 0x40

		public ExpressionExpr(Expression e) { }

	}

	private readonly Dictionary _DictionaryOfParameters; //Field offset: 0x10
	private readonly Expression[] _ListOfParameters; //Field offset: 0x18
	private int _currentParameterIndex; //Field offset: 0x20

	private ExpressionTreeCallRewriter(Expression[] listOfParameters) { }

	private Expression GenerateArrayIndex(ExprCall pExpr) { }

	private Expression GenerateAssignment(ExprCall pExpr) { }

	private Expression GenerateBinaryOperator(ExprCall pExpr) { }

	private Expression GenerateCall(ExprCall pExpr) { }

	private static Expression GenerateConstantType(ExprCall pExpr) { }

	private Expression GenerateConvert(ExprCall pExpr) { }

	private Expression GenerateField(ExprCall pExpr) { }

	private Expression GenerateInvoke(ExprCall pExpr) { }

	private Expr GenerateLambda(ExprCall pExpr) { }

	private Expression GenerateNew(ExprCall pExpr) { }

	private Expression GenerateProperty(ExprCall pExpr) { }

	private Expression GenerateUnaryOperator(ExprCall pExpr) { }

	private Expression GenerateUserDefinedBinaryOperator(ExprCall pExpr) { }

	private Expression GenerateUserDefinedUnaryOperator(ExprCall pExpr) { }

	private Expression[] GetArgumentsFromArrayInit(ExprArrayInit arrinit) { }

	private Expression GetExpression(Expr pExpr) { }

	public static Expression Rewrite(ExprBinOp binOp, Expression[] listOfParameters) { }

	protected virtual Expr VisitCALL(ExprCall pExpr) { }

	protected virtual Expr VisitSAVE(ExprBinOp pExpr) { }

	protected virtual Expr VisitWRAP(ExprWrap pExpr) { }

}

