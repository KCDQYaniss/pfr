namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal abstract class ParentSymbol : Symbol
{
	public Symbol firstChild; //Field offset: 0x38
	private Symbol _lastChild; //Field offset: 0x40

	protected ParentSymbol() { }

	public void AddToChildList(Symbol sym) { }

}

