namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(BlockExpressionProxy))]
public class BlockExpression : Expression
{

	[ExcludeFromCodeCoverage]
	internal override int ExpressionCount
	{
		internal get { } //Length: 39
	}

	public ReadOnlyCollection Expressions
	{
		 get { } //Length: 20
	}

	public virtual ExpressionType NodeType
	{
		 get { } //Length: 6
	}

	public virtual Type Type
	{
		 get { } //Length: 91
	}

	public ReadOnlyCollection Variables
	{
		 get { } //Length: 20
	}

	internal BlockExpression() { }

	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	internal override int get_ExpressionCount() { }

	public ReadOnlyCollection get_Expressions() { }

	public virtual ExpressionType get_NodeType() { }

	public virtual Type get_Type() { }

	public ReadOnlyCollection get_Variables() { }

	[ExcludeFromCodeCoverage]
	internal override Expression GetExpression(int index) { }

	[ExcludeFromCodeCoverage]
	internal override ReadOnlyCollection GetOrMakeExpressions() { }

	internal override ReadOnlyCollection GetOrMakeVariables() { }

	internal static ReadOnlyCollection ReturnReadOnlyExpressions(BlockExpression provider, ref object collection) { }

	[ExcludeFromCodeCoverage]
	internal override BlockExpression Rewrite(ReadOnlyCollection variables, Expression[] args) { }

}

