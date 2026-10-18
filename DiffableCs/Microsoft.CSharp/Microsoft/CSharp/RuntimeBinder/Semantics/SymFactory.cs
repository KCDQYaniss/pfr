namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal static class SymFactory
{

	public static AggregateSymbol CreateAggregate(Name name, NamespaceOrAggregateSymbol parent) { }

	public static TypeParameterSymbol CreateClassTypeParameter(Name pName, AggregateSymbol pParent, int index, int indexTotal) { }

	public static EventSymbol CreateEvent(Name name, AggregateSymbol parent) { }

	public static IndexerSymbol CreateIndexer(Name name, ParentSymbol parent) { }

	public static LocalVariableSymbol CreateLocalVar(Name name, Scope parent, CType type) { }

	public static FieldSymbol CreateMemberVar(Name name, AggregateSymbol parent) { }

	public static MethodSymbol CreateMethod(Name name, AggregateSymbol parent) { }

	public static TypeParameterSymbol CreateMethodTypeParameter(Name pName, MethodSymbol pParent, int index, int indexTotal) { }

	public static NamespaceSymbol CreateNamespace(Name name, NamespaceSymbol parent) { }

	public static PropertySymbol CreateProperty(Name name, AggregateSymbol parent) { }

	public static Scope CreateScope() { }

	private static Symbol NewBasicSymbol(SYMKIND kind, Name name, ParentSymbol parent) { }

}

