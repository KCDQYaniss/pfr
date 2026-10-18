namespace System.Text.Json;

[Nullable(0)]
[NullableContext(2)]
public class JsonException : Exception
{
	internal string _message; //Field offset: 0x90
	[CompilerGenerated]
	private bool <AppendPathInformation>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private Nullable <LineNumber>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private Nullable <BytePositionInLine>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private string <Path>k__BackingField; //Field offset: 0xC0

	internal bool AppendPathInformation
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	public internal Nullable BytePositionInLine
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		internal set { } //Length: 11
	}

	public internal Nullable LineNumber
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		internal set { } //Length: 11
	}

	[Nullable(1)]
	public virtual string Message
	{
		[NullableContext(1)]
		 get { } //Length: 20
	}

	public internal string Path
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	public JsonException(string message, Exception innerException) { }

	public JsonException(string message) { }

	public JsonException() { }

	[NullableContext(1)]
	protected JsonException(SerializationInfo info, StreamingContext context) { }

	[CompilerGenerated]
	internal bool get_AppendPathInformation() { }

	[CompilerGenerated]
	public Nullable get_BytePositionInLine() { }

	[CompilerGenerated]
	public Nullable get_LineNumber() { }

	[NullableContext(1)]
	public virtual string get_Message() { }

	[CompilerGenerated]
	public string get_Path() { }

	[NullableContext(1)]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CompilerGenerated]
	internal void set_AppendPathInformation(bool value) { }

	[CompilerGenerated]
	internal void set_BytePositionInLine(Nullable value) { }

	[CompilerGenerated]
	internal void set_LineNumber(Nullable value) { }

	[CompilerGenerated]
	internal void set_Path(string value) { }

	internal void SetMessage(string message) { }

}

