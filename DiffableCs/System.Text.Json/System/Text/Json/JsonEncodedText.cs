namespace System.Text.Json;

[IsReadOnly]
public struct JsonEncodedText : IEquatable
{
	internal readonly byte[] _utf8Value; //Field offset: 0x0
	internal readonly string _value; //Field offset: 0x8

	public ReadOnlySpan EncodedUtf8Bytes
	{
		 get { } //Length: 149
	}

	private JsonEncodedText(byte[] utf8Value) { }

	[NullableContext(1)]
	public static JsonEncodedText Encode(string value, JavaScriptEncoder encoder = null) { }

	public static JsonEncodedText Encode(ReadOnlySpan value, JavaScriptEncoder encoder = null) { }

	public static JsonEncodedText Encode(ReadOnlySpan utf8Value, JavaScriptEncoder encoder = null) { }

	private static JsonEncodedText EncodeHelper(ReadOnlySpan utf8Value, JavaScriptEncoder encoder) { }

	public override bool Equals(JsonEncodedText other) { }

	[NullableContext(2)]
	public virtual bool Equals(object obj) { }

	public ReadOnlySpan get_EncodedUtf8Bytes() { }

	public virtual int GetHashCode() { }

	[NullableContext(1)]
	public virtual string ToString() { }

	private static JsonEncodedText TranscodeAndEncode(ReadOnlySpan value, JavaScriptEncoder encoder) { }

}

