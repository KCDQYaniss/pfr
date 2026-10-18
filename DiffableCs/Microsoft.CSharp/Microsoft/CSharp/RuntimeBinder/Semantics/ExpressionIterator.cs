namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ExpressionIterator
{
	private ExprList _pList; //Field offset: 0x10
	private Expr _pCurrent; //Field offset: 0x18

	public ExpressionIterator(Expr pExpr) { }

	public bool AtEnd() { }

	public static int Count(Expr pExpr) { }

	public Expr Current() { }

	private void Init(Expr pExpr) { }

	public void MoveNext() { }

}

