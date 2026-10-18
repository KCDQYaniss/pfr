namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal abstract class ExprWithType : Expr
{

	protected ExprWithType(ExpressionKind kind, CType type) { }

	protected static bool TypesAreEqual(Type t1, Type t2) { }

}

