namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class LocalVariableSymbol : VariableSymbol
{
	public ExprWrap wrap; //Field offset: 0x40

	public LocalVariableSymbol() { }

	public CType GetType() { }

	public void SetType(CType pType) { }

}

