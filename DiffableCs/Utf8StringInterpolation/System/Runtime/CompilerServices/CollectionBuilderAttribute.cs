namespace System.Runtime.CompilerServices;

[AttributeUsage(1036, Inherited = False)]
[ExcludeFromCodeCoverage]
[Nullable(0)]
[NullableContext(1)]
internal sealed class CollectionBuilderAttribute : Attribute
{
	[CompilerGenerated]
	private readonly Type <BuilderType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <MethodName>k__BackingField; //Field offset: 0x18

	public Type BuilderType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string MethodName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public CollectionBuilderAttribute(Type builderType, string methodName) { }

	[CompilerGenerated]
	public Type get_BuilderType() { }

	[CompilerGenerated]
	public string get_MethodName() { }

}

