namespace System.Text.Json;

[Nullable(0)]
[NullableContext(1)]
public abstract class JsonNamingPolicy
{
	[CompilerGenerated]
	private static readonly JsonNamingPolicy <CamelCase>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly JsonNamingPolicy <SnakeCaseLower>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static readonly JsonNamingPolicy <SnakeCaseUpper>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private static readonly JsonNamingPolicy <KebabCaseLower>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private static readonly JsonNamingPolicy <KebabCaseUpper>k__BackingField; //Field offset: 0x20

	private static JsonNamingPolicy() { }

	protected JsonNamingPolicy() { }

	public abstract string ConvertName(string name) { }

}

