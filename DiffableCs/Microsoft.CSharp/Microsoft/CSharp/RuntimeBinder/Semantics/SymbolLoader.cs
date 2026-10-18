namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal static class SymbolLoader
{

	private static bool AreTypesEqualForConversion(CType pType1, CType pType2) { }

	public static AggregateSymbol GetPredefAgg(PredefinedType pt) { }

	public static AggregateType GetPredefindType(PredefinedType pt) { }

	private static bool HasAnyBaseInterfaceConversion(CType pDerived, CType pBase) { }

	private static bool HasArrayConversionToInterface(ArrayType pSource, CType pDest) { }

	public static bool HasBaseConversion(CType pSource, CType pDest) { }

	private static bool HasCovariantArrayConversion(ArrayType pSource, ArrayType pDest) { }

	private static bool HasDelegateConversion(AggregateType pSource, AggregateType pDest) { }

	public static bool HasIdentityOrImplicitReferenceConversion(CType pSource, CType pDest) { }

	private static bool HasImplicitBoxingConversion(CType pSource, CType pDest) { }

	private static bool HasImplicitReferenceConversion(CType pSource, CType pDest) { }

	private static bool HasInterfaceConversion(AggregateType pSource, AggregateType pDest) { }

	private static bool HasVariantConversion(AggregateType pSource, AggregateType pDest) { }

	public static bool IsBaseAggregate(AggregateSymbol derived, AggregateSymbol base) { }

	private static bool IsBaseClass(CType pDerived, CType pBase) { }

	public static bool IsBaseClassOfClass(CType pDerived, CType pBase) { }

	private static bool IsBaseInterface(AggregateType atsDer, AggregateType pBase) { }

	public static Symbol LookupAggMember(Name name, AggregateSymbol agg, symbmask_t mask) { }

}

