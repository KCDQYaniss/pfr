namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal static class PredefinedMembers
{
	private static readonly MethodSymbol[] _methods; //Field offset: 0x0
	private static readonly PropertySymbol[] _properties; //Field offset: 0x8
	private static readonly PredefinedPropertyInfo[] s_predefinedProperties; //Field offset: 0x10
	private static readonly PredefinedMethodInfo[] s_predefinedMethods; //Field offset: 0x18

	private static PredefinedMembers() { }

	private static PredefinedMethodInfo GetMethInfo(PREDEFMETH method) { }

	public static MethodSymbol GetMethod(PREDEFMETH method) { }

	private static AggregateSymbol GetPredefAgg(PredefinedType pt) { }

	public static PropertySymbol GetProperty(PREDEFPROP property) { }

	private static PREDEFMETH GetPropGetter(PREDEFPROP property) { }

	private static PredefinedPropertyInfo GetPropInfo(PREDEFPROP property) { }

	private static PredefinedType GetPropPredefType(PREDEFPROP property) { }

	private static MethodSymbol LoadMethod(AggregateSymbol type, int[] signature, int cMethodTyVars, Name methodName, ACCESS methodAccess, bool isStatic, bool isVirtual) { }

	private static MethodSymbol LoadMethod(PREDEFMETH method) { }

	private static PropertySymbol LoadProperty(PREDEFPROP property) { }

	private static PropertySymbol LoadProperty(PREDEFPROP predefProp, Name propertyName, PREDEFMETH propertyGetter) { }

	private static TypeArray LoadTypeArrayFromSignature(int[] signature, ref int indexIntoSignatures, TypeArray classTyVars) { }

	private static CType LoadTypeFromSignature(int[] signature, ref int indexIntoSignatures, TypeArray classTyVars) { }

	private static MethodSymbol LookupMethodWhileLoading(AggregateSymbol type, int cMethodTyVars, Name methodName, ACCESS methodAccess, bool isStatic, bool isVirtual, CType returnType, TypeArray argumentTypes) { }

}

