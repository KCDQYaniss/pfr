namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal static class Operators
{
	private sealed class OperatorInfo
	{
		public readonly TokenKind TokenKind; //Field offset: 0x10
		public readonly PredefinedName MethodName; //Field offset: 0x14
		public readonly ExpressionKind ExpressionKind; //Field offset: 0x18

		public OperatorInfo(TokenKind kind, PredefinedName pn, ExpressionKind e) { }

	}

	private static readonly OperatorInfo[] s_operatorInfos; //Field offset: 0x0
	private static Dictionary s_operatorsByName; //Field offset: 0x8

	private static Operators() { }

	public static string GetDisplayName(OperatorKind op) { }

	public static ExpressionKind GetExpressionKind(OperatorKind op) { }

	private static OperatorInfo GetInfo(OperatorKind op) { }

	private static Dictionary GetOperatorByName() { }

	public static string OperatorOfMethodName(Name name) { }

}

