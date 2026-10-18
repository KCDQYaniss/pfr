namespace System.Text.Json.Serialization.Metadata;

[EditorBrowsable(EditorBrowsableState::Never (1))]
[Nullable(0)]
[NullableContext(1)]
public sealed class JsonParameterInfoValues
{
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Type <ParameterType>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly int <Position>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly bool <HasDefaultValue>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private readonly object <DefaultValue>k__BackingField; //Field offset: 0x28

	[Nullable(2)]
	public object DefaultValue
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
		[CompilerGenerated]
		[NullableContext(2)]
		 set { } //Length: 82
	}

	public bool HasDefaultValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Type ParameterType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public int Position
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public JsonParameterInfoValues() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public object get_DefaultValue() { }

	[CompilerGenerated]
	public bool get_HasDefaultValue() { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public Type get_ParameterType() { }

	[CompilerGenerated]
	public int get_Position() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public void set_DefaultValue(object value) { }

	[CompilerGenerated]
	public void set_HasDefaultValue(bool value) { }

	[CompilerGenerated]
	public void set_Name(string value) { }

	[CompilerGenerated]
	public void set_ParameterType(Type value) { }

	[CompilerGenerated]
	public void set_Position(int value) { }

}

