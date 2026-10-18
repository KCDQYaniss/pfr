namespace System.Linq.Expressions;

internal class DynamicExpression4 : DynamicExpression, IArgumentProvider
{
	private object _arg0; //Field offset: 0x20
	private readonly Expression _arg1; //Field offset: 0x28
	private readonly Expression _arg2; //Field offset: 0x30
	private readonly Expression _arg3; //Field offset: 0x38

	private override int System.Linq.Expressions.IArgumentProvider.ArgumentCount
	{
		private get { } //Length: 6
	}

	internal DynamicExpression4(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	internal virtual ReadOnlyCollection GetOrMakeArguments() { }

	internal virtual DynamicExpression Rewrite(Expression[] args) { }

	private override int System.Linq.Expressions.IArgumentProvider.get_ArgumentCount() { }

	private override Expression System.Linq.Expressions.IArgumentProvider.GetArgument(int index) { }

}

