namespace System.Linq.Expressions;

internal static class ExpressionExtension
{

	private static MethodInfo GetValidMethodForDynamic(Type delegateType) { }

	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression[] arguments) { }

	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, IEnumerable arguments) { }

	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0) { }

	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1) { }

	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2) { }

	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	private static void ValidateDynamicArgument(Expression arg, string paramName) { }

	private static void ValidateDynamicArgument(Expression arg, string paramName, int index) { }

}

