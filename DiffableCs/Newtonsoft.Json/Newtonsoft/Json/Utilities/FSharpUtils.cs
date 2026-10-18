namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal class FSharpUtils
{
	[CompilerGenerated]
	private sealed class <>c__55`2
	{
		[Nullable(0)]
		public static readonly <>c__55 <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func <>9__55_1; //Field offset: 0x0

		private static <>c__55`2() { }

		public <>c__55`2() { }

		[NullableContext(0)]
		internal Tuple <BuildMapCreator>b__55_1(KeyValuePair kv) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2, 2})]
		public MethodCall call; //Field offset: 0x10
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2, 1})]
		public MethodCall invoke; //Field offset: 0x18

		public <>c__DisplayClass52_0() { }

		internal object <CreateFSharpFuncCall>b__0(object target, object[] args) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0`2
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public ObjectConstructor ctorDelegate; //Field offset: 0x0

		public <>c__DisplayClass55_0`2() { }

		internal object <BuildMapCreator>b__0(object[] args) { }

	}

	private static readonly object Lock; //Field offset: 0x0
	public const string FSharpSetTypeName = "FSharpSet`1"; //Field offset: 0x0
	public const string FSharpListTypeName = "FSharpList`1"; //Field offset: 0x0
	public const string FSharpMapTypeName = "FSharpMap`2"; //Field offset: 0x0
	[Nullable(2)]
	private static FSharpUtils _instance; //Field offset: 0x8
	private MethodInfo _ofSeq; //Field offset: 0x10
	private Type _mapType; //Field offset: 0x18
	[CompilerGenerated]
	private Assembly <FSharpCoreAssembly>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	private MethodCall <IsUnion>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	private MethodCall <GetUnionCases>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	private MethodCall <PreComputeUnionTagReader>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	private MethodCall <PreComputeUnionReader>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	private MethodCall <PreComputeUnionConstructor>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private Func <GetUnionCaseInfoDeclaringType>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private Func <GetUnionCaseInfoName>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private Func <GetUnionCaseInfoTag>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {1, 1, 2})]
	private MethodCall <GetUnionCaseInfoFields>k__BackingField; //Field offset: 0x68

	public private Assembly FSharpCoreAssembly
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Func GetUnionCaseInfoDeclaringType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 1, 2})]
	public private MethodCall GetUnionCaseInfoFields
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Func GetUnionCaseInfoName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Func GetUnionCaseInfoTag
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	public private MethodCall GetUnionCases
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public static FSharpUtils Instance
	{
		 get { } //Length: 84
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	public private MethodCall IsUnion
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	public private MethodCall PreComputeUnionConstructor
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	public private MethodCall PreComputeUnionReader
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	public private MethodCall PreComputeUnionTagReader
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static FSharpUtils() { }

	private FSharpUtils(Assembly fsharpCoreAssembly) { }

	[NullableContext(2)]
	public ObjectConstructor BuildMapCreator() { }

	private static MethodCall CreateFSharpFuncCall(Type type, string methodName) { }

	public ObjectConstructor CreateMap(Type keyType, Type valueType) { }

	public ObjectConstructor CreateSeq(Type t) { }

	public static void EnsureInitialized(Assembly fsharpCoreAssembly) { }

	[CompilerGenerated]
	public Assembly get_FSharpCoreAssembly() { }

	[CompilerGenerated]
	public Func get_GetUnionCaseInfoDeclaringType() { }

	[CompilerGenerated]
	public MethodCall get_GetUnionCaseInfoFields() { }

	[CompilerGenerated]
	public Func get_GetUnionCaseInfoName() { }

	[CompilerGenerated]
	public Func get_GetUnionCaseInfoTag() { }

	[CompilerGenerated]
	public MethodCall get_GetUnionCases() { }

	public static FSharpUtils get_Instance() { }

	[CompilerGenerated]
	public MethodCall get_IsUnion() { }

	[CompilerGenerated]
	public MethodCall get_PreComputeUnionConstructor() { }

	[CompilerGenerated]
	public MethodCall get_PreComputeUnionReader() { }

	[CompilerGenerated]
	public MethodCall get_PreComputeUnionTagReader() { }

	private static MethodInfo GetMethodWithNonPublicFallback(Type type, string methodName, BindingFlags bindingFlags) { }

	[CompilerGenerated]
	private void set_FSharpCoreAssembly(Assembly value) { }

	[CompilerGenerated]
	private void set_GetUnionCaseInfoDeclaringType(Func value) { }

	[CompilerGenerated]
	private void set_GetUnionCaseInfoFields(MethodCall value) { }

	[CompilerGenerated]
	private void set_GetUnionCaseInfoName(Func value) { }

	[CompilerGenerated]
	private void set_GetUnionCaseInfoTag(Func value) { }

	[CompilerGenerated]
	private void set_GetUnionCases(MethodCall value) { }

	[CompilerGenerated]
	private void set_IsUnion(MethodCall value) { }

	[CompilerGenerated]
	private void set_PreComputeUnionConstructor(MethodCall value) { }

	[CompilerGenerated]
	private void set_PreComputeUnionReader(MethodCall value) { }

	[CompilerGenerated]
	private void set_PreComputeUnionTagReader(MethodCall value) { }

}

