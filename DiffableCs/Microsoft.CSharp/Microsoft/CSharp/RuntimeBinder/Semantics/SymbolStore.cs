namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal static class SymbolStore
{
	[IsReadOnly]
	private struct Key : IEquatable
	{
		private readonly Name _name; //Field offset: 0x0
		private readonly ParentSymbol _parent; //Field offset: 0x8

		public Key(Name name, ParentSymbol parent) { }

		public override bool Equals(Key other) { }

		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

	}

	private static readonly Dictionary s_dictionary; //Field offset: 0x0

	private static SymbolStore() { }

	private static Symbol FindCorrectKind(Symbol sym, symbmask_t kindmask) { }

	public static void InsertChild(ParentSymbol parent, Symbol child) { }

	private static void InsertChildNoGrow(Symbol child) { }

	public static Symbol LookupSym(Name name, ParentSymbol parent, symbmask_t kindmask) { }

}

