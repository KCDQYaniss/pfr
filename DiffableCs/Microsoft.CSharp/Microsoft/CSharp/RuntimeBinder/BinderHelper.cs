namespace Microsoft.CSharp.RuntimeBinder;

[Extension]
internal static class BinderHelper
{
	private static MethodInfo s_DoubleIsNaN; //Field offset: 0x0
	private static MethodInfo s_SingleIsNaN; //Field offset: 0x8

	internal static DynamicMetaObject Bind(ICSharpBinder action, RuntimeBinder binder, DynamicMetaObject[] args, IEnumerable arginfos, DynamicMetaObject onBindingError) { }

	internal static T[] Cons(T sourceHead, T[] sourceTail) { }

	internal static T[] Cons(T sourceHead, T[] sourceMiddle, T sourceLast) { }

	private static Expression ConvertResult(Expression binding, ICSharpBinder action) { }

	internal static CallInfo CreateCallInfo(ref IEnumerable argInfos, int discard) { }

	private static BindingRestrictions DeduceArgumentRestriction(int parameterIndex, ICSharpInvokeOrInvokeMemberBinder callPayload, DynamicMetaObject argument, CSharpArgumentInfo info) { }

	[Extension]
	internal static string GetCLROperatorName(ExpressionType p) { }

	private static Type GetTypeForErrorMetaObject(ICSharpBinder action, DynamicMetaObject[] args) { }

	private static bool IsComObject(object obj) { }

	private static bool IsDynamicallyTypedRuntimeProxy(DynamicMetaObject argument, CSharpArgumentInfo info) { }

	private static bool IsIncrementOrDecrementActionOnLocal(ICSharpBinder action) { }

	private static bool IsTransparentProxy(object obj) { }

	private static bool IsTypeOfStaticCall(int parameterIndex, ICSharpInvokeOrInvokeMemberBinder callPayload) { }

	internal static T[] ToArray(IEnumerable source) { }

	public static void ValidateBindArgument(DynamicMetaObject argument, string paramName) { }

	public static void ValidateBindArgument(DynamicMetaObject[] arguments, string paramName) { }

}

