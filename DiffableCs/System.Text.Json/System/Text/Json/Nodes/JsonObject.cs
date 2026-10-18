namespace System.Text.Json.Nodes;

[DebuggerDisplay("JsonObject[{Count}]")]
[DebuggerTypeProxy(typeof(DebugView))]
[Nullable(0)]
[NullableContext(1)]
public sealed class JsonObject : JsonNode, IDictionary, ICollection, IEnumerable, IEnumerable
{
	[ExcludeFromCodeCoverage]
	private sealed class DebugView
	{

	}

	private Nullable _jsonElement; //Field offset: 0x20
	private JsonPropertyDictionary _dictionary; //Field offset: 0x38

	public override int Count
	{
		 get { } //Length: 89
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2})]
	internal JsonPropertyDictionary Dictionary
	{
		internal get { } //Length: 17
	}

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override ICollection System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.Keys
	{
		private get { } //Length: 348
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2})]
	private override ICollection System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.Values
	{
		private get { } //Length: 109
	}

	public JsonObject(Nullable options = null) { }

	internal JsonObject(JsonElement element, Nullable options = null) { }

	public override void Add(KeyValuePair property) { }

	public override void Add(string propertyName, JsonNode value) { }

	public override void Clear() { }

	public override bool ContainsKey(string propertyName) { }

	private void DetachParent(JsonNode item) { }

	public override int get_Count() { }

	internal JsonPropertyDictionary get_Dictionary() { }

	public override IEnumerator GetEnumerator() { }

	internal JsonNode GetItem(string propertyName) { }

	private void GetUnderlyingRepresentation(out JsonPropertyDictionary dictionary, out Nullable jsonElement) { }

	private JsonPropertyDictionary InitializeDictionary() { }

	public override bool Remove(string propertyName) { }

	internal void SetItem(string propertyName, JsonNode value) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.Contains(KeyValuePair item) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.CopyTo(KeyValuePair[] array, int index) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.get_IsReadOnly() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.Remove(KeyValuePair item) { }

	private override ICollection System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.get_Keys() { }

	private override ICollection System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.get_Values() { }

	private override bool System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.TryGetValue(string propertyName, out JsonNode jsonNode) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool TryGetPropertyValue(string propertyName, out JsonNode jsonNode) { }

	public virtual void WriteTo(Utf8JsonWriter writer, JsonSerializerOptions options = null) { }

}

