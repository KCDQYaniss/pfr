namespace System.Linq.Expressions;

internal class DynamicExpression1 : DynamicExpression, IArgumentProvider
{
	private object _arg0; //Field offset: 0x20

	private override int System.Linq.Expressions.IArgumentProvider.ArgumentCount
	{
		private get { } //Length: 6
	}

	internal DynamicExpression1(Type delegateType, CallSiteBinder binder, Expression arg0) { }

	internal virtual ReadOnlyCollection GetOrMakeArguments() { }

	internal virtual DynamicExpression Rewrite(Expression[] args) { }

	private override int System.Linq.Expressions.IArgumentProvider.get_ArgumentCount() { }

	private override Expression System.Linq.Expressions.IArgumentProvider.GetArgument(int index) { }

}

