namespace JsonType;

public sealed class FlatItem
{
	public MongoID _id; //Field offset: 0x10
	public MongoID _tpl; //Field offset: 0x28
	[JsonIgnore]
	public Nullable parentId; //Field offset: 0x40
	[JsonProperty(NullValueHandling = NullValueHandling::Ignore (1))]
	public string slotId; //Field offset: 0x60
	[JsonProperty(NullValueHandling = NullValueHandling::Ignore (1))]
	public UnparsedData location; //Field offset: 0x68
	[JsonProperty(NullValueHandling = NullValueHandling::Ignore (1))]
	public UnparsedData upd; //Field offset: 0x70

	[JsonProperty("parentId", NullValueHandling = NullValueHandling::Ignore (1))]
	[UsedImplicitly]
	private string StringParentId
	{
		private get { } //Length: 254
		private set { } //Length: 569
	}

	public FlatItem() { }

	public FlatItem Clone(MongoID id, MongoID parent, string slot) { }

	private string get_StringParentId() { }

	private void set_StringParentId(string value) { }

}

