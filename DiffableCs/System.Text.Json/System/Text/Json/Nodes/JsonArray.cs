namespace System.Text.Json.Nodes;

[DebuggerDisplay("JsonArray[{List.Count}]")]
[DebuggerTypeProxy(typeof(DebugView))]
[Nullable(0)]
[NullableContext(2)]
public sealed class JsonArray : JsonNode, IList, ICollection, IEnumerable, IEnumerable
{
	[ExcludeFromCodeCoverage]
	private sealed class DebugView
	{

	}

	private Nullable _jsonElement; //Field offset: 0x20
	private List _list; //Field offset: 0x38

	public override int Count
	{
		 get { } //Length: 80
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2})]
	internal List List
	{
		internal get { } //Length: 17
	}

	private override bool System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.IsReadOnly
	{
		private get { } //Length: 3
	}

	internal JsonArray(JsonElement element, Nullable options = null) { }

	public override void Add(JsonNode item) { }

	public override void Clear() { }

	public override bool Contains(JsonNode item) { }

	private static void DetachParent(JsonNode item) { }

	public override int get_Count() { }

	internal List get_List() { }

	public override IEnumerator GetEnumerator() { }

	internal JsonNode GetItem(int index) { }

	private void GetUnderlyingRepresentation(out List list, out Nullable jsonElement) { }

	public override int IndexOf(JsonNode item) { }

	private List InitializeList() { }

	public override void Insert(int index, JsonNode item) { }

	public override bool Remove(JsonNode item) { }

	public override void RemoveAt(int index) { }

	internal void SetItem(int index, JsonNode value) { }

	private override void System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.CopyTo(JsonNode[] array, int index) { }

	private override bool System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.get_IsReadOnly() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[NullableContext(1)]
	public virtual void WriteTo(Utf8JsonWriter writer, JsonSerializerOptions options = null) { }

}

