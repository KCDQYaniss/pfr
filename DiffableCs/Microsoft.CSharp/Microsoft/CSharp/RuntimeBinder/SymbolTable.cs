namespace Microsoft.CSharp.RuntimeBinder;

internal static class SymbolTable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public MethodBase methodBase; //Field offset: 0x10
		public Func <>9__0; //Field offset: 0x18

		public <>c__DisplayClass22_0() { }

		internal bool <BuildDeclarationChain>b__0(MethodInfo m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public Name property; //Field offset: 0x10

		public <>c__DisplayClass42_0() { }

		internal bool <AddPredefinedPropertyToSymbolTable>b__0(PropertyInfo x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public Name methodName; //Field offset: 0x10
		public Type t; //Field offset: 0x18

		public <>c__DisplayClass44_0() { }

		internal bool <AddPredefinedMethodToSymbolTable>b__0(MethodInfo m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public string name; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_1
	{
		public Type type; //Field offset: 0x10
		public <>c__DisplayClass7_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass7_1() { }

		internal bool <AddNamesInInheritanceHierarchy>b__0(MemberInfo member) { }

	}

	[IsReadOnly]
	private struct NameHashKey : IEquatable
	{
		[CompilerGenerated]
		private readonly Type <Type>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly string <Name>k__BackingField; //Field offset: 0x8

		internal string Name
		{
			[CompilerGenerated]
			internal get { } //Length: 5
		}

		internal Type Type
		{
			[CompilerGenerated]
			internal get { } //Length: 4
		}

		public NameHashKey(Type type, string name) { }

		public override bool Equals(NameHashKey other) { }

		public virtual bool Equals(object obj) { }

		[CompilerGenerated]
		internal string get_Name() { }

		[CompilerGenerated]
		internal Type get_Type() { }

		public virtual int GetHashCode() { }

	}

	private static readonly HashSet s_typesWithConversionsLoaded; //Field offset: 0x0
	private static readonly HashSet s_namesLoadedForEachType; //Field offset: 0x8
	private static readonly Type s_Sentinel; //Field offset: 0x10
	private static Type s_EventRegistrationTokenType; //Field offset: 0x18
	private static Type s_WindowsRuntimeMarshal; //Field offset: 0x20
	private static Type s_EventRegistrationTokenTable; //Field offset: 0x28

	private static Type EventRegistrationTokenTableType
	{
		private get { } //Length: 112
	}

	internal static Type EventRegistrationTokenType
	{
		internal get { } //Length: 112
	}

	internal static Type WindowsRuntimeMarshalType
	{
		internal get { } //Length: 112
	}

	private static SymbolTable() { }

	private static AggregateSymbol AddAggregateToSymbolTable(NamespaceOrAggregateSymbol parent, Type type) { }

	private static void AddConversionsForOneType(Type type) { }

	internal static void AddConversionsForType(Type type) { }

	private static void AddEventToSymbolTable(EventInfo eventInfo, AggregateSymbol aggregate, FieldSymbol addedField) { }

	private static FieldSymbol AddFieldToSymbolTable(FieldInfo fieldInfo, AggregateSymbol aggregate) { }

	private static MethodSymbol AddMethodToSymbolTable(MethodBase member, AggregateSymbol callingAggregate, MethodKindEnum kind) { }

	private static void AddNamesInInheritanceHierarchy(string name, List inheritance) { }

	private static void AddNamesOnType(NameHashKey key) { }

	private static NamespaceSymbol AddNamespaceToSymbolTable(NamespaceOrAggregateSymbol parent, string sz) { }

	private static void AddParameterConversions(MethodBase method) { }

	internal static void AddPredefinedMethodToSymbolTable(AggregateSymbol type, Name methodName) { }

	internal static void AddPredefinedPropertyToSymbolTable(AggregateSymbol type, Name property) { }

	private static void AddPropertyToSymbolTable(PropertyInfo property, AggregateSymbol aggregate) { }

	private static TypeParameterType AddTypeParameterToSymbolTable(AggregateSymbol agg, MethodSymbol meth, Type t, bool bIsAggregate) { }

	internal static bool AggregateContainsMethod(AggregateSymbol agg, string szName, symbmask_t mask) { }

	private static bool AreTypeParametersEquivalent(Type t1, Type t2) { }

	private static List BuildDeclarationChain(Type callingType) { }

	private static List CreateInheritanceHierarchyList(Type type) { }

	private static TypeArray CreateParameterArray(MemberInfo associatedInfo, ParameterInfo[] parameters) { }

	private static bool DoesMethodHaveParameterArray(ParameterInfo[] parameters) { }

	private static MethodSymbol FindMatchingMethod(MemberInfo method, AggregateSymbol callingAggregate) { }

	private static MethodSymbol FindMethodFromMemberInfo(MemberInfo baseMemberInfo) { }

	private static AggregateSymbol FindSymForType(Symbol sym, Type t) { }

	private static Type get_EventRegistrationTokenTableType() { }

	internal static Type get_EventRegistrationTokenType() { }

	internal static Type get_WindowsRuntimeMarshalType() { }

	private static TypeArray GetAggregateTypeParameters(Type type, AggregateSymbol agg) { }

	private static CType GetConstructedType(Type type, AggregateSymbol agg) { }

	private static uint GetCountOfModOpts(ParameterInfo[] parameters) { }

	internal static CType[] GetCTypeArrayFromTypes(Type[] types) { }

	internal static CType GetCTypeFromType(Type type) { }

	private static TypeArray GetMethodTypeParameters(MethodInfo method, MethodSymbol parent) { }

	private static Name GetName(Type type) { }

	private static Name GetName(string p) { }

	private static Type GetOriginalTypeParameterType(Type t) { }

	private static SymWithType GetSlotForOverride(MethodInfo method) { }

	private static Type GetTypeByName(ref Type cachedResult, string name) { }

	private static CType GetTypeOfParameter(ParameterInfo p, MemberInfo m) { }

	private static bool IsOperator(MethodInfo method) { }

	private static TypeParameterType LoadClassTypeParameter(AggregateSymbol parent, Type t) { }

	private static TypeParameterType LoadMethodTypeParameter(MethodSymbol parent, Type t) { }

	private static CType LoadSymbolsFromType(Type type) { }

	internal static SymWithType LookupMember(string name, Expr callingObject, ParentSymbol context, int arity, MemberLookup mem, bool allowSpecialNames, bool requireInvocable) { }

	internal static void PopulateSymbolTableWithName(string name, IEnumerable typeArguments, Type callingType) { }

	private static TypeParameterType ProcessMethodTypeParameter(MethodInfo methinfo, Type t, AggregateSymbol parent) { }

	private static CType ProcessSpecialTypeInChain(NamespaceOrAggregateSymbol parent, Type t) { }

	private static void SetInterfacesOnAggregate(AggregateSymbol aggregate, Type type) { }

	private static void SetParameterAttributes(MethodOrPropertySymbol methProp, ParameterInfo[] parameters, int i) { }

	private static void SetParameterDataForMethProp(MethodOrPropertySymbol methProp, ParameterInfo[] parameters) { }

}

