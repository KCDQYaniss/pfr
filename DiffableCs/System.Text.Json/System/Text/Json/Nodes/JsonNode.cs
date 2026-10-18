namespace System.Text.Json.Nodes;

[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
public abstract class JsonNode
{
	private JsonNode _parent; //Field offset: 0x10
	private Nullable _options; //Field offset: 0x18

	[Nullable(2)]
	public override JsonNode Item
	{
		[NullableContext(2)]
		 get { } //Length: 228
		[NullableContext(2)]
		 set { } //Length: 141
	}

	[Nullable(2)]
	public override JsonNode Item
	{
		 get { } //Length: 330
		 set { } //Length: 426
	}

	public Nullable Options
	{
		 get { } //Length: 80
	}

	[Nullable(2)]
	public internal JsonNode Parent
	{
		[NullableContext(2)]
		 get { } //Length: 5
		internal set { } //Length: 82
	}

	internal JsonNode(Nullable options = null) { }

	public JsonArray AsArray() { }

	public JsonObject AsObject() { }

	internal void AssignParent(JsonNode parent) { }

	[NullableContext(2)]
	public override JsonNode get_Item(int index) { }

	public override JsonNode get_Item(string propertyName) { }

	public Nullable get_Options() { }

	[NullableContext(2)]
	public JsonNode get_Parent() { }

	[NullableContext(2)]
	public override void set_Item(int index, JsonNode value) { }

	public override void set_Item(string propertyName, JsonNode value) { }

	internal void set_Parent(JsonNode value) { }

	public virtual string ToString() { }

	public abstract void WriteTo(Utf8JsonWriter writer, JsonSerializerOptions options = null) { }

	internal PooledByteBufferWriter WriteToPooledBuffer(JsonSerializerOptions options = null, JsonWriterOptions writerOptions = null, int bufferSize = 16384) { }

}

