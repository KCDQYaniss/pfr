namespace System.Linq.Expressions;

internal class ScopeN : ScopeExpression
{
	private IReadOnlyList _body; //Field offset: 0x18

	protected IReadOnlyList Body
	{
		 get { } //Length: 5
	}

	internal virtual int ExpressionCount
	{
		internal get { } //Length: 75
	}

	internal ScopeN(IReadOnlyList variables, IReadOnlyList body) { }

	protected IReadOnlyList get_Body() { }

	internal virtual int get_ExpressionCount() { }

	internal virtual Expression GetExpression(int index) { }

	internal virtual ReadOnlyCollection GetOrMakeExpressions() { }

	internal virtual BlockExpression Rewrite(ReadOnlyCollection variables, Expression[] args) { }

}

