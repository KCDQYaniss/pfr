namespace System.Text.Json;

[Nullable(0)]
[NullableContext(2)]
public struct JsonWriterOptions
{
	private int _maxDepth; //Field offset: 0x0
	private int _optionsMask; //Field offset: 0x4
	[CompilerGenerated]
	private JavaScriptEncoder <Encoder>k__BackingField; //Field offset: 0x8

	public JavaScriptEncoder Encoder
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public bool Indented
	{
		 get { } //Length: 7
		 set { } //Length: 25
	}

	internal bool IndentedOrNotSkipValidation
	{
		internal get { } //Length: 8
	}

	public int MaxDepth
	{
		[IsReadOnly]
		 get { } //Length: 3
		 set { } //Length: 79
	}

	public bool SkipValidation
	{
		 get { } //Length: 8
		 set { } //Length: 25
	}

	[CompilerGenerated]
	[IsReadOnly]
	public JavaScriptEncoder get_Encoder() { }

	public bool get_Indented() { }

	internal bool get_IndentedOrNotSkipValidation() { }

	[IsReadOnly]
	public int get_MaxDepth() { }

	public bool get_SkipValidation() { }

	[CompilerGenerated]
	public void set_Encoder(JavaScriptEncoder value) { }

	public void set_Indented(bool value) { }

	public void set_MaxDepth(int value) { }

	public void set_SkipValidation(bool value) { }

}

