namespace System.Text.Json.Serialization;

[AttributeUsage(1436, AllowMultiple = False)]
[Nullable(0)]
[NullableContext(1)]
public class JsonConverterAttribute : JsonAttribute
{
	[CompilerGenerated]
	private Type <ConverterType>k__BackingField; //Field offset: 0x10

	[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes::PublicParameterlessConstructor (1))]
	[Nullable(2)]
	public Type ConverterType
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
	}

	public override JsonConverter CreateConverter(Type typeToConvert) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public Type get_ConverterType() { }

}

