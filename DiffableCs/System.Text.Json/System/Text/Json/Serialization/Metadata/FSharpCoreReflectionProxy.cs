namespace System.Text.Json.Serialization.Metadata;

internal sealed class FSharpCoreReflectionProxy
{
	internal enum FSharpKind
	{
		Unrecognized = 0,
		Option = 1,
		ValueOption = 2,
		List = 3,
		Set = 4,
		Map = 5,
		Record = 6,
		Union = 7,
	}

	private enum SourceConstructFlags
	{
		None = 0,
		SumType = 1,
		RecordType = 2,
		ObjectType = 3,
		Field = 4,
		Exception = 5,
		Closure = 6,
		Module = 7,
		UnionCase = 8,
		Value = 9,
		KindMask = 31,
		NonPublicRepresentation = 32,
	}

	internal sealed class StructGetter`2 : MulticastDelegate
	{

		public StructGetter`2(object object, IntPtr method) { }

		public override TResult Invoke(ref TStruct this) { }

	}

	private static FSharpCoreReflectionProxy s_singletonInstance; //Field offset: 0x0
	private readonly Type _compilationMappingAttributeType; //Field offset: 0x10
	private readonly MethodInfo _sourceConstructFlagsGetter; //Field offset: 0x18
	private readonly Type _fsharpOptionType; //Field offset: 0x20
	private readonly Type _fsharpValueOptionType; //Field offset: 0x28
	private readonly Type _fsharpListType; //Field offset: 0x30
	private readonly Type _fsharpSetType; //Field offset: 0x38
	private readonly Type _fsharpMapType; //Field offset: 0x40
	private readonly MethodInfo _fsharpListCtor; //Field offset: 0x48
	private readonly MethodInfo _fsharpSetCtor; //Field offset: 0x50
	private readonly MethodInfo _fsharpMapCtor; //Field offset: 0x58

	public static FSharpCoreReflectionProxy Instance
	{
		 get { } //Length: 59
	}

	[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
	[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
	private FSharpCoreReflectionProxy(Assembly fsharpCoreAssembly) { }

	private static TDelegate CreateDelegate(MethodInfo methodInfo) { }

	[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
	[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
	public Func CreateFSharpListConstructor() { }

	[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
	[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
	public Func CreateFSharpMapConstructor() { }

	[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
	[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
	public Func CreateFSharpOptionSomeConstructor() { }

	[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
	[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
	public Func CreateFSharpOptionValueGetter() { }

	[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
	[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
	public Func CreateFSharpSetConstructor() { }

	[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
	[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
	public Func CreateFSharpValueOptionSomeConstructor() { }

	[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
	[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
	public StructGetter CreateFSharpValueOptionValueGetter() { }

	[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
	[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
	public FSharpKind DetectFSharpKind(Type type) { }

	private static TMemberInfo EnsureMemberExists(TMemberInfo memberInfo, string memberName) { }

	public static FSharpCoreReflectionProxy get_Instance() { }

	private Attribute GetFSharpCompilationMappingAttribute(Type type) { }

	private static Assembly GetFSharpCoreAssembly(Type type) { }

	private SourceConstructFlags GetSourceConstructFlags(Attribute compilationMappingAttribute) { }

	[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
	[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
	public static bool IsFSharpType(Type type) { }

}

