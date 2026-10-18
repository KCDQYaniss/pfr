namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal static class TypeManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__38_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal AssemblyName <InternalsVisibleTo>b__38_0(InternalsVisibleToAttribute ivta) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public AssemblyName assyName; //Field offset: 0x10

		public <>c__DisplayClass38_0() { }

		internal bool <InternalsVisibleTo>b__1(AssemblyName an) { }

	}

	private sealed class StdTypeVarColl
	{
		private readonly List prgptvs; //Field offset: 0x10

		public StdTypeVarColl() { }

		public TypeParameterType GetTypeVarSym(int iv, bool fMeth) { }

	}

	private static readonly Dictionary s_internalsVisibleToCache; //Field offset: 0x0
	private static readonly StdTypeVarColl s_stvcMethod; //Field offset: 0x8

	private static TypeManager() { }

	public static AggregateType GetAggregate(AggregateSymbol agg, AggregateType atsOuter, TypeArray typeArgs) { }

	public static AggregateType GetAggregate(AggregateSymbol agg, TypeArray typeArgsAll) { }

	public static ArrayType GetArray(CType elementType, int args, bool isSZArray) { }

	internal static CType GetBestAccessibleType(AggregateSymbol context, CType typeSrc) { }

	public static NullableType GetNullable(CType pUnderlyingType) { }

	public static AggregateSymbol GetNullable() { }

	public static ParameterModifierType GetParameterModifier(CType paramType, bool isOut) { }

	public static PointerType GetPointer(CType baseType) { }

	public static AggregateSymbol GetPredefAgg(PredefinedType pt) { }

	public static TypeParameterType GetStdMethTypeVar(int iv) { }

	public static TypeParameterType GetTypeParameter(TypeParameterSymbol pSymbol) { }

	internal static bool InternalsVisibleTo(Assembly assemblyThatDefinesAttribute, Assembly assemblyToCheck) { }

	public static bool SubstEqualTypeArrays(TypeArray taDst, TypeArray taSrc, TypeArray typeArgsCls, TypeArray typeArgsMeth) { }

	public static bool SubstEqualTypes(CType typeDst, CType typeSrc, CType typeCls) { }

	public static bool SubstEqualTypes(CType typeDst, CType typeSrc, TypeArray typeArgsCls, TypeArray typeArgsMeth, bool denormMeth) { }

	private static bool SubstEqualTypes(CType typeDst, CType typeSrc, CType typeCls, TypeArray typeArgsMeth) { }

	private static bool SubstEqualTypesCore(CType typeDst, CType typeSrc, SubstContext pctx) { }

	public static CType SubstType(CType typeSrc, AggregateType atsCls, TypeArray typeArgsMeth) { }

	private static CType SubstType(CType typeSrc, TypeArray typeArgsCls, TypeArray typeArgsMeth) { }

	public static CType SubstType(CType typeSrc, SubstContext pctx) { }

	public static CType SubstType(CType typeSrc, AggregateType atsCls) { }

	public static AggregateType SubstType(AggregateType typeSrc, TypeArray typeArgsCls) { }

	public static CType SubstType(CType typeSrc, CType typeCls, TypeArray typeArgsMeth) { }

	private static CType SubstType(CType typeSrc, TypeArray typeArgsCls, TypeArray typeArgsMeth, bool denormMeth) { }

	public static AggregateType SubstType(AggregateType typeSrc, SubstContext ctx) { }

	public static TypeArray SubstTypeArray(TypeArray taSrc, AggregateType atsCls) { }

	public static TypeArray SubstTypeArray(TypeArray taSrc, SubstContext ctx) { }

	public static TypeArray SubstTypeArray(TypeArray taSrc, TypeArray typeArgsCls) { }

	public static TypeArray SubstTypeArray(TypeArray taSrc, TypeArray typeArgsCls, TypeArray typeArgsMeth) { }

	public static TypeArray SubstTypeArray(TypeArray taSrc, AggregateType atsCls, TypeArray typeArgsMeth) { }

	private static CType SubstTypeCore(CType type, SubstContext pctx) { }

	private static AggregateType SubstTypeCore(AggregateType type, SubstContext ctx) { }

	private static bool TryArrayVarianceAdjustmentToGetAccessibleType(AggregateSymbol context, ArrayType typeSrc, out CType typeDst) { }

	private static bool TryVarianceAdjustmentToGetAccessibleType(AggregateSymbol context, AggregateType typeSrc, out CType typeDst) { }

	public static bool TypeContainsType(CType type, CType typeFind) { }

	public static bool TypeContainsTyVars(CType type, TypeArray typeVars) { }

}

