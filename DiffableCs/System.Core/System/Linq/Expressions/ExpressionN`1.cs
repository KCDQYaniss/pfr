namespace System.Linq.Expressions;

internal class ExpressionN`1 : Expression
{
	private IReadOnlyList _parameters; //Field offset: 0x0

	internal virtual int ParameterCount
	{
		internal get { } //Length: 75
	}

	public ExpressionN`1(Expression body, IReadOnlyList parameters) { }

	internal virtual int get_ParameterCount() { }

	internal virtual ParameterExpression GetParameter(int index) { }

	internal virtual Expression Rewrite(Expression body, ParameterExpression[] parameters) { }

}

