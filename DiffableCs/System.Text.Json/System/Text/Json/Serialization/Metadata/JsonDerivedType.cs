namespace System.Text.Json.Serialization.Metadata;

[IsReadOnly]
[Nullable(0)]
[NullableContext(1)]
public struct JsonDerivedType
{
	[CompilerGenerated]
	private readonly Type <DerivedType>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly object <TypeDiscriminator>k__BackingField; //Field offset: 0x8

	public Type DerivedType
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	[Nullable(2)]
	public object TypeDiscriminator
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
	}

	internal JsonDerivedType(Type derivedType, object typeDiscriminator) { }

	internal void Deconstruct(out Type derivedType, out object typeDiscriminator) { }

	[CompilerGenerated]
	public Type get_DerivedType() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public object get_TypeDiscriminator() { }

}

