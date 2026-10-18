namespace System.Linq.Expressions;

internal sealed class InstanceMethodCallExpressionN : InstanceMethodCallExpression, IArgumentProvider
{
	private IReadOnlyList _arguments; //Field offset: 0x20

	public virtual int ArgumentCount
	{
		 get { } //Length: 75
	}

	public InstanceMethodCallExpressionN(MethodInfo method, Expression instance, IReadOnlyList args) { }

	public virtual int get_ArgumentCount() { }

	public virtual Expression GetArgument(int index) { }

	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList args) { }

}

