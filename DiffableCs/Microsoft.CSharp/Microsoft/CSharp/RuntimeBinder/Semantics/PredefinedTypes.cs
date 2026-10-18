namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal static class PredefinedTypes
{
	private static readonly AggregateSymbol[] s_predefSymbols; //Field offset: 0x0

	private static PredefinedTypes() { }

	private static AggregateSymbol DelayLoadPredefSym(PredefinedType pt) { }

	private static string GetNiceName(PredefinedType pt) { }

	public static string GetNiceName(AggregateSymbol type) { }

	public static AggregateSymbol GetPredefinedAggregate(PredefinedType pt) { }

	internal static AggregateSymbol InitializePredefinedType(AggregateSymbol sym, PredefinedType pt) { }

}

