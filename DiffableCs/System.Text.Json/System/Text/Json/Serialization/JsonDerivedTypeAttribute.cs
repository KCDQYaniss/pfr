namespace System.Text.Json.Serialization;

[AttributeUsage(1028, AllowMultiple = True, Inherited = False)]
[Nullable(0)]
[NullableContext(1)]
public class JsonDerivedTypeAttribute : JsonAttribute
{
	[CompilerGenerated]
	private readonly Type <DerivedType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly object <TypeDiscriminator>k__BackingField; //Field offset: 0x18

	public Type DerivedType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[Nullable(2)]
	public object TypeDiscriminator
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
	}

	[CompilerGenerated]
	public Type get_DerivedType() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public object get_TypeDiscriminator() { }

}

