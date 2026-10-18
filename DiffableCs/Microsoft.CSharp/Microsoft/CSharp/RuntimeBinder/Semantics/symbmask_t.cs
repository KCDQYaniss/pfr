namespace Microsoft.CSharp.RuntimeBinder.Semantics;

[Flags]
internal enum symbmask_t
{
	MASK_NamespaceSymbol = 1,
	MASK_AggregateSymbol = 2,
	MASK_TypeParameterSymbol = 4,
	MASK_FieldSymbol = 8,
	MASK_MethodSymbol = 32,
	MASK_PropertySymbol = 64,
	MASK_EventSymbol = 128,
	MASK_ALL = -1,
	MASK_Member = 232,
}

