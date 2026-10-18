namespace System.Dynamic.Utils;

[Extension]
internal static class ExpressionUtils
{

	internal static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	public static void RequiresCanRead(Expression expression, string paramName) { }

	public static void RequiresCanRead(Expression expression, string paramName, int idx) { }

	public static T ReturnObject(object collectionOrT) { }

	public static ReadOnlyCollection ReturnReadOnly(ref IReadOnlyList collection) { }

	public static ReadOnlyCollection ReturnReadOnly(IArgumentProvider provider, ref object collection) { }

	internal static bool SameElements(ref IEnumerable replacement, IReadOnlyList current) { }

	private static bool SameElementsInCollection(ICollection replacement, IReadOnlyList current) { }

	public static bool TryQuote(Type parameterType, ref Expression argument) { }

	public static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	[Extension]
	public static void ValidateArgumentCount(LambdaExpression lambda) { }

	public static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection arguments, string methodParamName) { }

	public static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arguments, ParameterInfo pi, string methodParamName, string argumentParamName, int index = -1) { }

}

