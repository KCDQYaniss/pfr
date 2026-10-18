namespace System.Linq.Expressions;

internal sealed class MethodCallExpressionN : MethodCallExpression, IArgumentProvider
{
	private IReadOnlyList _arguments; //Field offset: 0x18

	public virtual int ArgumentCount
	{
		 get { } //Length: 75
	}

	public MethodCallExpressionN(MethodInfo method, IReadOnlyList args) { }

	public virtual int get_ArgumentCount() { }

	public virtual Expression GetArgument(int index) { }

	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList args) { }

}

