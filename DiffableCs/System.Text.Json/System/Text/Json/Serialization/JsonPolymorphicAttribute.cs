namespace System.Text.Json.Serialization;

[AttributeUsage(1028, AllowMultiple = False, Inherited = False)]
[Nullable(0)]
[NullableContext(2)]
public sealed class JsonPolymorphicAttribute : JsonAttribute
{
	[CompilerGenerated]
	private string <TypeDiscriminatorPropertyName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private JsonUnknownDerivedTypeHandling <UnknownDerivedTypeHandling>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IgnoreUnrecognizedTypeDiscriminators>k__BackingField; //Field offset: 0x1C

	public bool IgnoreUnrecognizedTypeDiscriminators
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string TypeDiscriminatorPropertyName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public JsonUnknownDerivedTypeHandling UnknownDerivedTypeHandling
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	[CompilerGenerated]
	public bool get_IgnoreUnrecognizedTypeDiscriminators() { }

	[CompilerGenerated]
	public string get_TypeDiscriminatorPropertyName() { }

	[CompilerGenerated]
	public JsonUnknownDerivedTypeHandling get_UnknownDerivedTypeHandling() { }

}

