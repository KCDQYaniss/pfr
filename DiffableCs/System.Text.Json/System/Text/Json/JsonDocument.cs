namespace System.Text.Json;

public sealed class JsonDocument : IDisposable
{
	[IsReadOnly]
	public struct DbRow
	{
		private readonly int _location; //Field offset: 0x0
		private readonly int _sizeOrLengthUnion; //Field offset: 0x4
		private readonly int _numberOfRowsAndTypeUnion; //Field offset: 0x8

		internal bool HasComplexChildren
		{
			internal get { } //Length: 7
		}

		internal bool IsSimpleValue
		{
			internal get { } //Length: 17
		}

		internal int Location
		{
			internal get { } //Length: 3
		}

		internal int NumberOfRows
		{
			internal get { } //Length: 9
		}

		internal int SizeOrLength
		{
			internal get { } //Length: 8
		}

		internal JsonTokenType TokenType
		{
			internal get { } //Length: 7
		}

		internal bool get_HasComplexChildren() { }

		internal bool get_IsSimpleValue() { }

		internal int get_Location() { }

		internal int get_NumberOfRows() { }

		internal int get_SizeOrLength() { }

		internal JsonTokenType get_TokenType() { }

	}

	private struct MetadataDb : IDisposable
	{
		[CompilerGenerated]
		private int <Length>k__BackingField; //Field offset: 0x0
		private byte[] _data; //Field offset: 0x8
		private bool _convertToAlloc; //Field offset: 0x10
		private bool _isLocked; //Field offset: 0x11

		private int Length
		{
			[CompilerGenerated]
			private set { } //Length: 3
		}

		public override void Dispose() { }

		internal DbRow Get(int index) { }

		internal JsonTokenType GetJsonTokenType(int index) { }

		[CompilerGenerated]
		private void set_Length(int value) { }

	}

	private ReadOnlyMemory _utf8Json; //Field offset: 0x10
	private MetadataDb _parsedData; //Field offset: 0x20
	private byte[] _extraRentedArrayPoolBytes; //Field offset: 0x38
	private PooledByteBufferWriter _extraPooledByteBufferWriter; //Field offset: 0x40
	[CompilerGenerated]
	private readonly bool <IsDisposable>k__BackingField; //Field offset: 0x48

	internal bool IsDisposable
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public JsonElement RootElement
	{
		 get { } //Length: 97
	}

	private static void CheckExpectedType(JsonTokenType expected, JsonTokenType actual) { }

	private void CheckNotDisposed() { }

	private static void ClearAndReturn(ArraySegment rented) { }

	public override void Dispose() { }

	[CompilerGenerated]
	internal bool get_IsDisposable() { }

	public JsonElement get_RootElement() { }

	internal int GetArrayLength(int index) { }

	internal int GetEndIndex(int index, bool includeEndElement) { }

	internal JsonTokenType GetJsonTokenType(int index) { }

	internal string GetNameOfPropertyValue(int index) { }

	private ReadOnlyMemory GetPropertyRawValue(int valueIndex) { }

	internal string GetPropertyRawValueAsString(int valueIndex) { }

	internal ReadOnlyMemory GetRawValue(int index, bool includeQuotes) { }

	internal string GetRawValueAsString(int index) { }

	internal string GetString(int index, JsonTokenType expectedType) { }

	private ReadOnlySpan UnescapeString(in DbRow row, out ArraySegment rented) { }

	private void WriteComplexElement(int index, Utf8JsonWriter writer) { }

	internal void WriteElementTo(int index, Utf8JsonWriter writer) { }

	private void WritePropertyName(in DbRow row, Utf8JsonWriter writer) { }

	private void WriteString(in DbRow row, Utf8JsonWriter writer) { }

	[NullableContext(1)]
	public void WriteTo(Utf8JsonWriter writer) { }

}

