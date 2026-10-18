namespace System.Text.Json;

[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DefaultMember("Item")]
[IsReadOnly]
public struct JsonElement
{
	[DebuggerDisplay("{Current,nq}")]
	internal struct ArrayEnumerator : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private readonly JsonElement _target; //Field offset: 0x0
		private int _curIdx; //Field offset: 0x10
		private readonly int _endIdxOrVersion; //Field offset: 0x14

		public override JsonElement Current
		{
			 get { } //Length: 148
		}

		[Nullable(1)]
		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 189
		}

		internal ArrayEnumerator(JsonElement target) { }

		public override void Dispose() { }

		public override JsonElement get_Current() { }

		public ArrayEnumerator GetEnumerator() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override IEnumerator System.Collections.Generic.IEnumerable<System.Text.Json.JsonElement>.GetEnumerator() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[DebuggerDisplay("{Current,nq}")]
	internal struct ObjectEnumerator : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private readonly JsonElement _target; //Field offset: 0x0
		private int _curIdx; //Field offset: 0x10
		private readonly int _endIdxOrVersion; //Field offset: 0x14

		public override JsonProperty Current
		{
			 get { } //Length: 363
		}

		[Nullable(1)]
		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 100
		}

		internal ObjectEnumerator(JsonElement target) { }

		public override void Dispose() { }

		public override JsonProperty get_Current() { }

		public ObjectEnumerator GetEnumerator() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override IEnumerator System.Collections.Generic.IEnumerable<System.Text.Json.JsonProperty>.GetEnumerator() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private readonly JsonDocument _parent; //Field offset: 0x0
	private readonly int _idx; //Field offset: 0x8

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private JsonTokenType TokenType
	{
		private get { } //Length: 103
	}

	public JsonValueKind ValueKind
	{
		 get { } //Length: 136
	}

	internal JsonElement(JsonDocument parent, int idx) { }

	private void CheckValidInstance() { }

	public ArrayEnumerator EnumerateArray() { }

	public ObjectEnumerator EnumerateObject() { }

	private JsonTokenType get_TokenType() { }

	public JsonValueKind get_ValueKind() { }

	public int GetArrayLength() { }

	internal string GetPropertyName() { }

	internal string GetPropertyRawText() { }

	[NullableContext(2)]
	public string GetString() { }

	[NullableContext(1)]
	public virtual string ToString() { }

	[NullableContext(1)]
	public void WriteTo(Utf8JsonWriter writer) { }

}

