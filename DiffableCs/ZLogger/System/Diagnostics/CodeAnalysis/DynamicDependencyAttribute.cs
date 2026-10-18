namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(352, AllowMultiple = True, Inherited = False)]
[Conditional("MULTI_TARGETING_SUPPORT_ATTRIBUTES")]
[ExcludeFromCodeCoverage]
[Nullable(0)]
[NullableContext(2)]
internal sealed class DynamicDependencyAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <MemberSignature>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly DynamicallyAccessedMemberTypes <MemberTypes>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly string <TypeName>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <AssemblyName>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <Condition>k__BackingField; //Field offset: 0x38

	public string AssemblyName
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public string Condition
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public string MemberSignature
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public DynamicallyAccessedMemberTypes MemberTypes
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public Type Type
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string TypeName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[NullableContext(1)]
	public DynamicDependencyAttribute(string memberSignature) { }

	[NullableContext(1)]
	public DynamicDependencyAttribute(string memberSignature, Type type) { }

	[NullableContext(1)]
	public DynamicDependencyAttribute(string memberSignature, string typeName, string assemblyName) { }

	[NullableContext(1)]
	public DynamicDependencyAttribute(DynamicallyAccessedMemberTypes memberTypes, Type type) { }

	[NullableContext(1)]
	public DynamicDependencyAttribute(DynamicallyAccessedMemberTypes memberTypes, string typeName, string assemblyName) { }

	[CompilerGenerated]
	public string get_AssemblyName() { }

	[CompilerGenerated]
	public string get_Condition() { }

	[CompilerGenerated]
	public string get_MemberSignature() { }

	[CompilerGenerated]
	public DynamicallyAccessedMemberTypes get_MemberTypes() { }

	[CompilerGenerated]
	public Type get_Type() { }

	[CompilerGenerated]
	public string get_TypeName() { }

	[CompilerGenerated]
	public void set_Condition(string value) { }

}

