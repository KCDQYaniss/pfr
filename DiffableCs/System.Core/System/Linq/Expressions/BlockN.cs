namespace System.Linq.Expressions;

internal class BlockN : BlockExpression
{
	private IReadOnlyList _expressions; //Field offset: 0x10

	internal virtual int ExpressionCount
	{
		internal get { } //Length: 75
	}

	internal BlockN(IReadOnlyList expressions) { }

	internal virtual int get_ExpressionCount() { }

	internal virtual Expression GetExpression(int index) { }

	internal virtual ReadOnlyCollection GetOrMakeExpressions() { }

	internal virtual BlockExpression Rewrite(ReadOnlyCollection variables, Expression[] args) { }

}

