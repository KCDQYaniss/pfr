namespace System.Linq.Expressions;

internal class DynamicExpressionN : DynamicExpression, IArgumentProvider
{
	private IReadOnlyList _arguments; //Field offset: 0x20

	private override int System.Linq.Expressions.IArgumentProvider.ArgumentCount
	{
		private get { } //Length: 75
	}

	internal DynamicExpressionN(Type delegateType, CallSiteBinder binder, IReadOnlyList arguments) { }

	internal virtual ReadOnlyCollection GetOrMakeArguments() { }

	internal virtual DynamicExpression Rewrite(Expression[] args) { }

	private override int System.Linq.Expressions.IArgumentProvider.get_ArgumentCount() { }

	private override Expression System.Linq.Expressions.IArgumentProvider.GetArgument(int index) { }

}

