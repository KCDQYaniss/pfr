namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class NamespaceSymbol : NamespaceOrAggregateSymbol
{
	public static readonly NamespaceSymbol Root; //Field offset: 0x0

	private static NamespaceSymbol() { }

	public NamespaceSymbol() { }

	private static NamespaceSymbol GetRootNamespaceSymbol() { }

}

