namespace System.Text.Json;

[DebuggerDisplay("{DebuggerDisplay,nq}")]
[IsReadOnly]
[Nullable(0)]
[NullableContext(1)]
public struct JsonProperty
{
	[CompilerGenerated]
	private readonly JsonElement <Value>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <_name>k__BackingField; //Field offset: 0x10

	[Nullable(2)]
	private string _name
	{
		[CompilerGenerated]
		private get { } //Length: 5
	}

	public string Name
	{
		 get { } //Length: 120
	}

	public JsonElement Value
	{
		[CompilerGenerated]
		 get { } //Length: 10
	}

	internal JsonProperty(JsonElement value, string name = null) { }

	[CompilerGenerated]
	private string get__name() { }

	public string get_Name() { }

	[CompilerGenerated]
	public JsonElement get_Value() { }

	public virtual string ToString() { }

}

