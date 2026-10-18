namespace Microsoft.CSharp.RuntimeBinder.Semantics;

[Extension]
internal static class ExpressionKindExtensions
{

	[Extension]
	public static bool IsRelational(ExpressionKind kind) { }

	[Extension]
	public static bool IsUnaryOperator(ExpressionKind kind) { }

}

